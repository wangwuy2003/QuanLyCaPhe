namespace QuanLyQuanCaPhe
{
    partial class formTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbMatKhauTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaDanhMuc = new System.Windows.Forms.Button();
            this.btnSuaDanhMuc = new System.Windows.Forms.Button();
            this.btnThemDanhMuc = new System.Windows.Forms.Button();
            this.txbTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTenNguoiDung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 572);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMatKhauTaiKhoan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbLoaiTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXoaDanhMuc);
            this.groupBox1.Controls.Add(this.btnSuaDanhMuc);
            this.groupBox1.Controls.Add(this.btnThemDanhMuc);
            this.groupBox1.Controls.Add(this.txbTenTaiKhoan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbTenNguoiDung);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(489, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 498);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txbMatKhauTaiKhoan
            // 
            this.txbMatKhauTaiKhoan.Location = new System.Drawing.Point(208, 204);
            this.txbMatKhauTaiKhoan.Name = "txbMatKhauTaiKhoan";
            this.txbMatKhauTaiKhoan.PasswordChar = '*';
            this.txbMatKhauTaiKhoan.Size = new System.Drawing.Size(232, 25);
            this.txbMatKhauTaiKhoan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu:";
            // 
            // txbLoaiTaiKhoan
            // 
            this.txbLoaiTaiKhoan.Location = new System.Drawing.Point(208, 274);
            this.txbLoaiTaiKhoan.Name = "txbLoaiTaiKhoan";
            this.txbLoaiTaiKhoan.Size = new System.Drawing.Size(232, 25);
            this.txbLoaiTaiKhoan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại tài khoản:";
            // 
            // btnXoaDanhMuc
            // 
            this.btnXoaDanhMuc.BackColor = System.Drawing.Color.Moccasin;
            this.btnXoaDanhMuc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaDanhMuc.Location = new System.Drawing.Point(365, 363);
            this.btnXoaDanhMuc.Name = "btnXoaDanhMuc";
            this.btnXoaDanhMuc.Size = new System.Drawing.Size(75, 59);
            this.btnXoaDanhMuc.TabIndex = 7;
            this.btnXoaDanhMuc.Text = "Xóa";
            this.btnXoaDanhMuc.UseVisualStyleBackColor = false;
            this.btnXoaDanhMuc.Click += new System.EventHandler(this.btnXoaDanhMuc_Click);
            // 
            // btnSuaDanhMuc
            // 
            this.btnSuaDanhMuc.BackColor = System.Drawing.Color.Moccasin;
            this.btnSuaDanhMuc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuaDanhMuc.Location = new System.Drawing.Point(208, 363);
            this.btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            this.btnSuaDanhMuc.Size = new System.Drawing.Size(75, 59);
            this.btnSuaDanhMuc.TabIndex = 6;
            this.btnSuaDanhMuc.Text = "Sửa";
            this.btnSuaDanhMuc.UseVisualStyleBackColor = false;
            this.btnSuaDanhMuc.Click += new System.EventHandler(this.btnSuaDanhMuc_Click);
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.BackColor = System.Drawing.Color.Moccasin;
            this.btnThemDanhMuc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemDanhMuc.Location = new System.Drawing.Point(54, 363);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(75, 59);
            this.btnThemDanhMuc.TabIndex = 5;
            this.btnThemDanhMuc.Text = "Thêm";
            this.btnThemDanhMuc.UseVisualStyleBackColor = false;
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // txbTenTaiKhoan
            // 
            this.txbTenTaiKhoan.Location = new System.Drawing.Point(208, 127);
            this.txbTenTaiKhoan.Name = "txbTenTaiKhoan";
            this.txbTenTaiKhoan.Size = new System.Drawing.Size(232, 25);
            this.txbTenTaiKhoan.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên tài khoản:";
            // 
            // txbTenNguoiDung
            // 
            this.txbTenNguoiDung.Location = new System.Drawing.Point(208, 46);
            this.txbTenNguoiDung.Name = "txbTenNguoiDung";
            this.txbTenNguoiDung.Size = new System.Drawing.Size(232, 25);
            this.txbTenNguoiDung.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên người dùng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNguoiDung,
            this.tenHienThi,
            this.loaiTaiKhoan});
            this.dataGridView1.Location = new System.Drawing.Point(3, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(480, 498);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tenNguoiDung
            // 
            this.tenNguoiDung.DataPropertyName = "tenNguoiDung";
            this.tenNguoiDung.HeaderText = "Tên Người dùng";
            this.tenNguoiDung.Name = "tenNguoiDung";
            this.tenNguoiDung.Width = 150;
            // 
            // tenHienThi
            // 
            this.tenHienThi.DataPropertyName = "tenHienThi";
            this.tenHienThi.HeaderText = "Tên Tài Khoản";
            this.tenHienThi.Name = "tenHienThi";
            this.tenHienThi.Width = 150;
            // 
            // loaiTaiKhoan
            // 
            this.loaiTaiKhoan.DataPropertyName = "loaiTaiKhoan";
            this.loaiTaiKhoan.HeaderText = "Loại Tài Khoản";
            this.loaiTaiKhoan.Name = "loaiTaiKhoan";
            this.loaiTaiKhoan.Width = 140;
            // 
            // formTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 572);
            this.Controls.Add(this.panel1);
            this.Name = "formTaiKhoan";
            this.Text = "formTaiKhoan";
            this.Load += new System.EventHandler(this.formTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnXoaDanhMuc;
        private Button btnSuaDanhMuc;
        private Button btnThemDanhMuc;
        private TextBox txbTenTaiKhoan;
        private Label label5;
        private TextBox txbTenNguoiDung;
        private Label label6;
        private DataGridView dataGridView1;
        private TextBox txbLoaiTaiKhoan;
        private Label label1;
        private TextBox txbMatKhauTaiKhoan;
        private Label label2;
        private DataGridViewTextBoxColumn tenNguoiDung;
        private DataGridViewTextBoxColumn tenHienThi;
        private DataGridViewTextBoxColumn loaiTaiKhoan;
    }
}