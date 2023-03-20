using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class formHoaDon : Form
    {
        public formHoaDon()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        // Kết nối đến cơ sở dữ liệu và lấy dữ liệu từ bảng "Drinks"
        Modify modify = new Modify();

        private void formHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("Select ma, tenDoUong, giaBan from DoUong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCaPheDen_Click(object sender, EventArgs e)
        {
        }

        //Khai báo biến toàn cục để lưu trữ số lượng item trên ListView của mỗi đồ uống
        Dictionary<string, int> quantities = new Dictionary<string, int>();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy ra DataGridViewRow được chọn
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            // Lấy ra tên đồ uống
            string tenDoUong = row.Cells["tenDoUong"].Value.ToString();

            // Kiểm tra nếu chưa có item này trên ListView thì thêm mới
            if (!listView1.Items.ContainsKey(tenDoUong))
            {
                // Thêm item mới với số lượng là 1
                string giaBan = dataGridView1.Rows[e.RowIndex].Cells["giaBan"].Value.ToString();
                ListViewItem item = new ListViewItem(new[] { tenDoUong, "1", giaBan });
                item.Name = tenDoUong;
                listView1.Items.Add(item);

                // Lưu số lượng vào biến quantities
                quantities[tenDoUong] = 1;
            }
            else
            {
                // Nếu đã có item này trên ListView thì tăng số lượng lên 1
                ListViewItem item = listView1.Items[tenDoUong];
                int quantity = int.Parse(item.SubItems[1].Text) + 1;
                item.SubItems[1].Text = quantity.ToString();

                // Lưu số lượng vào biến quantities
                quantities[tenDoUong] = quantity;
            }


        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
            {

            }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
            {
            }
    }
}
