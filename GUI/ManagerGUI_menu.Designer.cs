namespace GUI
{
    partial class ManagerGUI_menu
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
            groupBox1 = new GroupBox();
            btnQuanLyNhanSu = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnThongKe = new Button();
            tabPage3 = new TabPage();
            tabPage2 = new TabPage();
            btnXoa1 = new Button();
            cbRole = new ComboBox();
            label6 = new Label();
            tbTimKiem1 = new TextBox();
            label5 = new Label();
            tbMatKhau = new TextBox();
            tbTaiKhoan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnShowLogInfo = new Button();
            tbID = new TextBox();
            tbHoTen = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSua1 = new Button();
            btnThem1 = new Button();
            btnHuy1 = new Button();
            btnGhi1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnQuanLyNhanSu);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnThongKe);
            groupBox1.Location = new Point(6, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 943);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // btnQuanLyNhanSu
            // 
            btnQuanLyNhanSu.Location = new Point(0, 288);
            btnQuanLyNhanSu.Name = "btnQuanLyNhanSu";
            btnQuanLyNhanSu.Size = new Size(323, 83);
            btnQuanLyNhanSu.TabIndex = 4;
            btnQuanLyNhanSu.Text = "Quản lý nhân sự";
            btnQuanLyNhanSu.UseVisualStyleBackColor = true;
            btnQuanLyNhanSu.Click += btnQuanLyNhanSu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 175);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(0, 867);
            button3.Name = "button3";
            button3.Size = new Size(323, 76);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(0, 377);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(323, 83);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1145, 905);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnXoa1);
            tabPage2.Controls.Add(cbRole);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(tbTimKiem1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(tbMatKhau);
            tabPage2.Controls.Add(tbTaiKhoan);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnShowLogInfo);
            tabPage2.Controls.Add(tbID);
            tabPage2.Controls.Add(tbHoTen);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnSua1);
            tabPage2.Controls.Add(btnThem1);
            tabPage2.Controls.Add(btnHuy1);
            tabPage2.Controls.Add(btnGhi1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1145, 902);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXoa1
            // 
            btnXoa1.Location = new Point(321, 227);
            btnXoa1.Name = "btnXoa1";
            btnXoa1.Size = new Size(112, 34);
            btnXoa1.TabIndex = 19;
            btnXoa1.Text = "Xóa";
            btnXoa1.UseVisualStyleBackColor = true;
            btnXoa1.Click += btnXoa1_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Quản lý", "Nhân viên bán hàng", "Kế toán", "Thủ kho", "Nhân viên chăm sóc khách hàng" });
            cbRole.Location = new Point(149, 148);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(284, 36);
            cbRole.TabIndex = 18;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 151);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 17;
            label6.Text = "Chức vụ";
            // 
            // tbTimKiem1
            // 
            tbTimKiem1.Location = new Point(907, 32);
            tbTimKiem1.Name = "tbTimKiem1";
            tbTimKiem1.Size = new Size(226, 34);
            tbTimKiem1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(810, 35);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 14;
            label5.Text = "Tìm kiếm";
            // 
            // tbMatKhau
            // 
            tbMatKhau.Enabled = false;
            tbMatKhau.Location = new Point(569, 93);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(150, 34);
            tbMatKhau.TabIndex = 13;
            tbMatKhau.TextChanged += tbMatKhau_TextChanged;
            // 
            // tbTaiKhoan
            // 
            tbTaiKhoan.Enabled = false;
            tbTaiKhoan.Location = new Point(569, 29);
            tbTaiKhoan.Name = "tbTaiKhoan";
            tbTaiKhoan.Size = new Size(150, 34);
            tbTaiKhoan.TabIndex = 12;
            tbTaiKhoan.TextChanged += tbTaiKhoan_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 35);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 11;
            label4.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 26);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 10;
            label3.Text = "ID";
            // 
            // btnShowLogInfo
            // 
            btnShowLogInfo.Location = new Point(738, 32);
            btnShowLogInfo.Name = "btnShowLogInfo";
            btnShowLogInfo.Size = new Size(41, 34);
            btnShowLogInfo.TabIndex = 9;
            btnShowLogInfo.Text = "button13";
            btnShowLogInfo.UseVisualStyleBackColor = true;
            btnShowLogInfo.Click += btnShowLogInfo_Click;
            // 
            // tbID
            // 
            tbID.Location = new Point(149, 26);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(284, 34);
            tbID.TabIndex = 8;
            tbID.TextChanged += tbID_TextChanged;
            // 
            // tbHoTen
            // 
            tbHoTen.Location = new Point(149, 88);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(284, 34);
            tbHoTen.TabIndex = 7;
            tbHoTen.TextChanged += tbHoTen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 94);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 93);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 5;
            label1.Text = "Họ tên";
            // 
            // btnSua1
            // 
            btnSua1.Location = new Point(165, 227);
            btnSua1.Name = "btnSua1";
            btnSua1.Size = new Size(112, 34);
            btnSua1.TabIndex = 4;
            btnSua1.Text = "Sửa";
            btnSua1.UseVisualStyleBackColor = true;
            btnSua1.Click += btnSua1_Click;
            // 
            // btnThem1
            // 
            btnThem1.Location = new Point(29, 227);
            btnThem1.Name = "btnThem1";
            btnThem1.Size = new Size(112, 34);
            btnThem1.TabIndex = 3;
            btnThem1.Text = "Thêm";
            btnThem1.UseVisualStyleBackColor = true;
            btnThem1.Click += btnThem1_Click;
            // 
            // btnHuy1
            // 
            btnHuy1.Enabled = false;
            btnHuy1.Location = new Point(477, 227);
            btnHuy1.Name = "btnHuy1";
            btnHuy1.Size = new Size(112, 34);
            btnHuy1.TabIndex = 2;
            btnHuy1.Text = "Hủy";
            btnHuy1.UseVisualStyleBackColor = true;
            btnHuy1.Click += btnHuy1_Click;
            // 
            // btnGhi1
            // 
            btnGhi1.Enabled = false;
            btnGhi1.Location = new Point(477, 171);
            btnGhi1.Name = "btnGhi1";
            btnGhi1.Size = new Size(112, 34);
            btnGhi1.TabIndex = 1;
            btnGhi1.Text = "Ghi";
            btnGhi1.UseVisualStyleBackColor = true;
            btnGhi1.Click += btnGhi1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, Column4 });
            dataGridView1.Location = new Point(5, 290);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1140, 604);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column5
            // 
            Column5.HeaderText = "Chức vụ";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 300;
            // 
            // Column3
            // 
            Column3.FillWeight = 1F;
            Column3.HeaderText = "Tên đăng nhập";
            Column3.MinimumWidth = 100;
            Column3.Name = "Column3";
            Column3.Visible = false;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Mật khẩu";
            Column4.MinimumWidth = 100;
            Column4.Name = "Column4";
            Column4.Visible = false;
            Column4.Width = 150;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(329, 14);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1153, 943);
            tabControl1.TabIndex = 18;
            // 
            // ManagerGUI_menu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 944);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ManagerGUI_menu";
            Text = "ManagerGUI_menu";
            Load += ManagerGUI_menu_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnQuanLyNhanSu;
        private PictureBox pictureBox1;
        private Button button3;
        private Button btnThongKe;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private Button btnShowLogInfo;
        private TextBox tbID;
        private TextBox tbHoTen;
        private Label label2;
        private Label label1;
        private Button btnSua1;
        private Button btnThem1;
        private Button btnHuy1;
        private Button btnGhi1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private Label label4;
        private Label label3;
        private TextBox tbMatKhau;
        private TextBox tbTaiKhoan;
        private TextBox tbTimKiem1;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Colunm5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cbRole;
        private DataGridViewTextBoxColumn Column5;
        private Button btnXoa1;
    }
}