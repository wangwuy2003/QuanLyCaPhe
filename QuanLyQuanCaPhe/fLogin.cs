using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace QuanLyQuanCaPhe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }


        SqlConnection conn  = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private void fLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            formMainAdmin f = new formMainAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        Modify modify= new Modify();
        //dang nhap
        private void button1_Click(object sender, EventArgs e)
        {
            string tenTK = txbTaiKhoan.Text;
            string matKhau = txbMatKhau.Text;
            if (tenTK.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !");
            }
            else
            {
                string query = "select * from TaiKhoan where tenHienThi = '" + tenTK + "' and matKhau = '" + matKhau + "'";
                if(modify.taiKhoans(query).Count > 0) 
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formMainAdmin f = new formMainAdmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}