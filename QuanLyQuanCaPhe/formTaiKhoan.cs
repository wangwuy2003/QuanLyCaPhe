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
    public partial class formTaiKhoan : Form
    {
        public formTaiKhoan()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void formTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("select tenNguoiDung, tenHienThi, loaiTaiKhoan from TaiKhoan");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            deleteTextBox();
        }
        private void deleteTextBox()
        {
            txbTenNguoiDung.Text = "";
            txbTenTaiKhoan.Text = "";
            txbLoaiTaiKhoan.Text = "";
            txbMatKhauTaiKhoan.Text = "";
        }

        //kiem tra text box da dien chua
        private bool checkTextBox()
        {
            if (txbTenNguoiDung.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên người dùng");
                return false;
            }
            if (txbTenTaiKhoan.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên tài khoản");
                return false;
            }
            if (txbLoaiTaiKhoan.Text == "")
            {
                MessageBox.Show("Mời bạn nhập loại tài khoản");
                return false;
            }
            if (txbMatKhauTaiKhoan.Text == "")
            {
                MessageBox.Show("Mời bạn nhập mật khẩu");
                return false;
            }
            return true;
        }


        QuanLyTaiKhoan quanly;

        private void getValueTextBox()
        {
            string _tenNguoiDung = txbTenNguoiDung.Text;
            string _tenHienThi = txbTenTaiKhoan.Text;
            string _matKhau = txbMatKhauTaiKhoan.Text;
            int _loaiTaiKhoan = Convert.ToInt32(txbLoaiTaiKhoan.Text);
            quanly = new QuanLyTaiKhoan(_tenNguoiDung, _tenHienThi, _matKhau, _loaiTaiKhoan);
        }

        //Add Function
        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                getValueTextBox();
                string query = "insert into TaiKhoan values (N'" + quanly.TenNguoiDung + "', N'" + quanly.TenHienThi  + "', N'" + quanly.MatKhau + "', " + quanly.LoaiTaiKhoan + ")";
                try
                {
                    modify.Command(query);
                    MessageBox.Show("Thêm thành công!");
                    formTaiKhoan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm: " + ex.Message);
                }
            }
        }

        //Edit Function
        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                getValueTextBox();
                string query = "update TaiKhoan set tenNguoiDung = '" + quanly.TenNguoiDung + "', matKhau = '" + quanly.MatKhau + "', loaiTaiKhoan = " + quanly.LoaiTaiKhoan + "where tenHienThi ='" + quanly.TenHienThi + "'";
                try
                {
                    modify.Command(query);
                    MessageBox.Show("Sửa thành công!");
                    formTaiKhoan_Load(sender, e);
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
            txbTenNguoiDung.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txbTenTaiKhoan.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txbLoaiTaiKhoan.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        //Delete Function
        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                string choose = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "delete from TaiKhoan where tenHienThi = '" + choose + "'";
                try
                {
                    modify.Command(query);
                    MessageBox.Show("Xoá thành công!");
                    formTaiKhoan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá: " + ex.Message);
                }
            }
        }
    }
}
