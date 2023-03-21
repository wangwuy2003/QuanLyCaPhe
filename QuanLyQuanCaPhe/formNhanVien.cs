using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class formNhanVien : Form
    {
        public formNhanVien()
        {
            InitializeComponent();
        }
        Modify modify= new Modify();
        NhanVien nhanvien;
        private void formNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = this.txbMaNV.Text;
            string ten = this.txbTenNV.Text;
            string gioitinh = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            DateTime ngaysinh = this.dateTimePicker1.Value;
            string sodienthoai = this.txbSDT.Text;
            nhanvien = new NhanVien(ma, ten, gioitinh, ngaysinh, sodienthoai);
            if (modify.insert(nhanvien))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không thể thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = this.txbMaNV.Text;
            string ten = this.txbTenNV.Text;
            string gioitinh = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            DateTime ngaysinh = this.dateTimePicker1.Value;
            string sodienthoai = this.txbSDT.Text;
            nhanvien = new NhanVien(ma, ten, gioitinh, ngaysinh, sodienthoai);
            if (modify.update(nhanvien))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không thể sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.delete(ma))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không thể xoá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaNV.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txbTenNV.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txbSDT.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
