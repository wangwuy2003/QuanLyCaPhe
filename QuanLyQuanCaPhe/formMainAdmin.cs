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
    public partial class formMainAdmin : Form
    {
        public formMainAdmin()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag= childForm; 
            childForm.BringToFront();
            childForm.Show();
        }

        private void tablemanager_Load(object sender, EventArgs e)
        {

        }

        private void nmDem_ValueChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tablemanager_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new formHoaDon());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new formThucDon());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new formDanhMuc());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new formDoanhThu());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new formTaiKhoan());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new formNhanVien());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new formNhanVien());
        }
    }
}
