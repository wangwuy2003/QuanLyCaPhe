using Microsoft.Data.SqlClient;
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
    public partial class formThucDon : Form
    {
        public formThucDon()
        {
            InitializeComponent();
        }

        //search function
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = txb_TimKiem.Text.Trim();
            if(name == "")
            {
                formThucDon_Load(sender, e);
            }
            else
            {
                string query = "select * from DoUong where tenDoUong like '" + name + "%'";
                dataGridView1.DataSource = modify.Table(query);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Modify modify = new Modify();
        private void formThucDon_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("Select * from DoUong");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }           
            deleteTextBox();
        }

        // xoa du lieu
        private void deleteTextBox()
        {
            txbThucDonID.Text = "";
            txbTenThucDon.Text = "";
            txbThucDonDanhMuc.Text = "";
            txbGiaThucDon.Text = "";
        }

        //kiem tra text box da dien chua
        private bool checkTextBox()
        {
            if (txbThucDonID.Text == "")
            {
                MessageBox.Show("Mời bạn nhập ID");
                return false;
            }
            if (txbTenThucDon.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên");
                return false;
            }
            if (txbThucDonDanhMuc.Text == "")
            {
                MessageBox.Show("Mời bạn nhập danh mục");
                return false;
            }
            return true;
        }

        //lay tu file QuanLyThucDon.cs
        QuanLyThucDon quanly1;
        private void getValueTextBox()
        {
            int _idThucDon = Convert.ToInt32(txbThucDonID.Text);
            string _tenThucDon = txbTenThucDon.Text;
            string _thucDonDanhMuc = txbThucDonDanhMuc.Text;
            double _giaThucDon = Convert.ToInt32(txbGiaThucDon.Text);
            quanly1 = new QuanLyThucDon(_idThucDon, _tenThucDon, _thucDonDanhMuc, _giaThucDon);
        }

        // Add Function
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                getValueTextBox();
                string query = "insert into DoUong values (" + quanly1.IdThucDon + ", N'" + quanly1.TenThucDon + "', " + quanly1.ThucDonDanhMuc + ", " + quanly1.GiaThucDon + ")";
                try
                {
                    modify.Command(query);
                    MessageBox.Show("Thêm thành công!");
                    formThucDon_Load(sender, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi thêm: " + ex.Message);
                }
            }
        }

        //Edit function
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                getValueTextBox();
                string query = "update DoUong set tenDoUong = '" + quanly1.TenThucDon + "', giaBan = " + quanly1.GiaThucDon + "where ma =" + quanly1.IdThucDon;
                try
                {
                    modify.Command(query);
                    MessageBox.Show("Sửa thành công!");
                    formThucDon_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa: " + ex.Message);
                }
            }
        }


        //biding data from dataGridView to textbox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbThucDonID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txbTenThucDon.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txbThucDonDanhMuc.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txbGiaThucDon.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        //Delete Function
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                string choose = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "delete from DoUong where ma = " + Convert.ToInt32(choose) + " ";
                try
                {
                    modify.Command(query);
                    MessageBox.Show("Xoá thành công!");
                    formThucDon_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá: " + ex.Message);
                }
            }
        }
    }
}
