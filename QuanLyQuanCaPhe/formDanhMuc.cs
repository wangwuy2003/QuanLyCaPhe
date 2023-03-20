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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCaPhe
{
    public partial class formDanhMuc : Form
    {
        public formDanhMuc()
        {
            InitializeComponent();
        }
        //Modify modify = new Modify();

        string chuoiketnoi = @"Data Source=DESKTOP-GQN6708;Initial Catalog=QuanLyCaPhe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        
        private void formDanhMuc_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql = "select * from DanhMucDoUong";
            //khai bao, khoi tao mot bien kieu sqlDataAdapter voi cau lenh truy van va connection da khoi tao o tren
            SqlDataAdapter dataDanhMuc = new SqlDataAdapter(sql, conn);
            DataTable dataTable= new DataTable();
            //do du lieu truy van duoc vao bang
            dataDanhMuc.Fill(dataTable);
            //hien thi du lieu tu bang len giao dien
            dataGridView1.DataSource = dataTable;
            deleteTextBox();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTenDanhMuc_TextChanged(object sender, EventArgs e)
        {
        }
        
        //Cell dataGridView click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbDanhMucID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txbTenDanhMuc.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void deleteTextBox()
        {
            txbDanhMucID.Text = "";
            txbTenDanhMuc.Text = "";
        }

        //kiem tra text box da dien du lieu chua
        private bool checkTextBox()
        {
            if (txbDanhMucID.Text == "")
            {
                MessageBox.Show("Mời bạn đặt ID");
                return false;
            }
            if (txbTenDanhMuc.Text == "")
            {
                MessageBox.Show("Mời bạn đặt tên");
                return false;
            }
            return true;
        }

        //lay tu file QuanLyDanhMuc.cs
        QuanLyDanhMuc quanly;

        //lay gia tri trong textbox
        private void getValueTextBox()
        {
            string _idDanhMuc = txbDanhMucID.Text;
            string _tenDanhMuc = txbTenDanhMuc.Text;
            quanly = new QuanLyDanhMuc(_idDanhMuc, _tenDanhMuc);

        }

        // Add Function
        private void button7_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                getValueTextBox();
                string query = "insert into DanhMucDoUong values('" + quanly.IdDanhMuc + "', N'" + quanly.TenDanhMuc + "')";
                try
                {   
                    if(MessageBox.Show("Bạn có muốn thêm vào không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand(query, conn); // dung sql de thuc hien cac cau lenh cap nhat du lieu nhu insert, update, delete
                        cmd.ExecuteNonQuery(); // thuc hien cau lenh trong chuoi query
                        //dataGridView1.Rows.Clear();
                        MessageBox.Show("Thêm thành công!");
                        formDanhMuc_Load(sender, e);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi thêm: " + ex.Message);
                }
            }
        }


        //Edit function
        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                getValueTextBox();
                string query = "update DanhMucDoUong set ten = N'" + quanly.TenDanhMuc + "'";
                query += "where ma = " + quanly.IdDanhMuc; 
                try
                {
                    if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand(query, conn); // dung sql de thuc hien cac cau lenh cap nhat du lieu nhu insert, update, delete
                        cmd.ExecuteNonQuery(); // thuc hien cau lenh trong chuoi query
                        //dataGridView1.Rows.Clear();
                        MessageBox.Show("Sửa thành công!");
                        formDanhMuc_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa: " + ex.Message);
                }
            }
        }

        //Delete function
        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                string choose = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string query = "delete from DanhMucDoUong where ma = " + Convert.ToInt32(choose) + " ";
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand(query, conn); // dung sql de thuc hien cac cau lenh cap nhat du lieu nhu insert, update, delete
                        cmd.ExecuteNonQuery(); // thuc hien cau lenh trong chuoi query
                                               //dataGridView1.Rows.Clear();
                        MessageBox.Show("Xóa thành công!");
                        formDanhMuc_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            } 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
