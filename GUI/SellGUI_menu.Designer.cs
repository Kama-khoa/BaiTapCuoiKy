namespace GUI
{
    partial class SellGUI_menu
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            btnSanPham = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnOrder = new Button();
            btnCustomer = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            cboTimKiem = new ComboBox();
            cbTimKiem = new CheckBox();
            txbTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnHuy = new Button();
            txbAddress = new TextBox();
            txbPhone = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txbName = new TextBox();
            txbID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnGhi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            dgvKhachHang = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            btnSuaOrder = new Button();
            btnThemOrder = new Button();
            txbSoLuong = new TextBox();
            label10 = new Label();
            button14 = new Button();
            button13 = new Button();
            txbSDT = new TextBox();
            label7 = new Label();
            txbTenLaptop = new ComboBox();
            cboTenKhachhang = new ComboBox();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            label6 = new Label();
            label5 = new Label();
            dgvOrder = new DataGridView();
            colOrderID = new DataGridViewTextBoxColumn();
            colLaptop = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colKhachHang = new DataGridViewTextBoxColumn();
            colKeToan = new DataGridViewTextBoxColumn();
            colSeller = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSanPham);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnOrder);
            groupBox1.Controls.Add(btnCustomer);
            groupBox1.Location = new Point(-1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 943);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // btnSanPham
            // 
            btnSanPham.Location = new Point(0, 288);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(323, 83);
            btnSanPham.TabIndex = 4;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += button1_Click;
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
            button3.Text = "Đăng xuất";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(0, 466);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(323, 83);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(0, 377);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(323, 83);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Khách hàng";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(322, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1153, 943);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1145, 907);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cboTimKiem);
            tabPage2.Controls.Add(cbTimKiem);
            tabPage2.Controls.Add(txbTimKiem);
            tabPage2.Controls.Add(btnTimKiem);
            tabPage2.Controls.Add(btnHuy);
            tabPage2.Controls.Add(txbAddress);
            tabPage2.Controls.Add(txbPhone);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txbName);
            tabPage2.Controls.Add(txbID);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnGhi);
            tabPage2.Controls.Add(btnXoa);
            tabPage2.Controls.Add(btnThem);
            tabPage2.Controls.Add(btnSua);
            tabPage2.Controls.Add(dgvKhachHang);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1145, 907);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboTimKiem
            // 
            cboTimKiem.FormattingEnabled = true;
            cboTimKiem.Items.AddRange(new object[] { "ID", "Tên", "SĐT" });
            cboTimKiem.Location = new Point(707, 117);
            cboTimKiem.Name = "cboTimKiem";
            cboTimKiem.Size = new Size(128, 31);
            cboTimKiem.TabIndex = 17;
            // 
            // cbTimKiem
            // 
            cbTimKiem.AutoSize = true;
            cbTimKiem.Location = new Point(596, 114);
            cbTimKiem.Name = "cbTimKiem";
            cbTimKiem.Size = new Size(101, 27);
            cbTimKiem.TabIndex = 16;
            cbTimKiem.Text = "Tìm kiếm";
            cbTimKiem.UseVisualStyleBackColor = true;
            cbTimKiem.CheckedChanged += cbTimKiem_CheckedChanged;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(710, 158);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(125, 30);
            txbTimKiem.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(596, 158);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(598, 50);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txbAddress
            // 
            txbAddress.Location = new Point(146, 226);
            txbAddress.Name = "txbAddress";
            txbAddress.Size = new Size(188, 30);
            txbAddress.TabIndex = 12;
            txbAddress.TextChanged += txbAddress_TextChanged;
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(148, 172);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(186, 30);
            txbPhone.TabIndex = 11;
            txbPhone.TextChanged += txbPhone_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 218);
            label9.Name = "label9";
            label9.Size = new Size(65, 23);
            label9.TabIndex = 10;
            label9.Text = "Địa Chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 173);
            label8.Name = "label8";
            label8.Size = new Size(40, 23);
            label8.TabIndex = 9;
            label8.Text = "SĐT";
            // 
            // txbName
            // 
            txbName.Location = new Point(149, 110);
            txbName.Name = "txbName";
            txbName.Size = new Size(185, 30);
            txbName.TabIndex = 8;
            txbName.TextChanged += txbName_TextChanged;
            // 
            // txbID
            // 
            txbID.Location = new Point(149, 49);
            txbID.Name = "txbID";
            txbID.Size = new Size(185, 30);
            txbID.TabIndex = 7;
            txbID.TextChanged += txbID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 110);
            label2.Name = "label2";
            label2.Size = new Size(36, 23);
            label2.TabIndex = 6;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 52);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // btnGhi
            // 
            btnGhi.ContextMenuStrip = contextMenuStrip1;
            btnGhi.DialogResult = DialogResult.Abort;
            btnGhi.Location = new Point(438, 222);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(112, 34);
            btnGhi.TabIndex = 4;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(438, 168);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(438, 45);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(438, 104);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colPhone, colAddress });
            dgvKhachHang.Location = new Point(-1, 266);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.RowTemplate.Height = 33;
            dgvKhachHang.Size = new Size(1140, 604);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colID.Frozen = true;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Resizable = DataGridViewTriState.False;
            colID.Width = 56;
            // 
            // colName
            // 
            colName.HeaderText = "Tên";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 200;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "SĐT";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.Width = 125;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Địa Chỉ";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnSuaOrder);
            tabPage3.Controls.Add(btnThemOrder);
            tabPage3.Controls.Add(txbSoLuong);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(button14);
            tabPage3.Controls.Add(button13);
            tabPage3.Controls.Add(txbSDT);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(txbTenLaptop);
            tabPage3.Controls.Add(cboTenKhachhang);
            tabPage3.Controls.Add(button11);
            tabPage3.Controls.Add(button10);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dgvOrder);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1145, 907);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSuaOrder
            // 
            btnSuaOrder.Location = new Point(392, 106);
            btnSuaOrder.Name = "btnSuaOrder";
            btnSuaOrder.Size = new Size(94, 29);
            btnSuaOrder.TabIndex = 20;
            btnSuaOrder.Text = "Sửa";
            btnSuaOrder.UseVisualStyleBackColor = true;
            // 
            // btnThemOrder
            // 
            btnThemOrder.Location = new Point(391, 52);
            btnThemOrder.Name = "btnThemOrder";
            btnThemOrder.Size = new Size(94, 29);
            btnThemOrder.TabIndex = 19;
            btnThemOrder.Text = "Thêm";
            btnThemOrder.UseVisualStyleBackColor = true;
            // 
            // txbSoLuong
            // 
            txbSoLuong.Location = new Point(173, 206);
            txbSoLuong.Name = "txbSoLuong";
            txbSoLuong.Size = new Size(182, 30);
            txbSoLuong.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(74, 205);
            label10.Name = "label10";
            label10.Size = new Size(78, 23);
            label10.TabIndex = 17;
            label10.Text = "Số lượng";
            // 
            // button14
            // 
            button14.Location = new Point(971, 164);
            button14.Name = "button14";
            button14.Size = new Size(112, 34);
            button14.TabIndex = 16;
            button14.Text = "Xóa";
            button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(391, 164);
            button13.Name = "button13";
            button13.Size = new Size(112, 34);
            button13.TabIndex = 15;
            button13.Text = "Tạo order";
            button13.UseVisualStyleBackColor = true;
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(173, 103);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(182, 30);
            txbSDT.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 153);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 13;
            label7.Text = "Laptop";
            // 
            // txbTenLaptop
            // 
            txbTenLaptop.FormattingEnabled = true;
            txbTenLaptop.Location = new Point(173, 153);
            txbTenLaptop.Name = "txbTenLaptop";
            txbTenLaptop.Size = new Size(182, 31);
            txbTenLaptop.TabIndex = 12;
            // 
            // cboTenKhachhang
            // 
            cboTenKhachhang.FormattingEnabled = true;
            cboTenKhachhang.Location = new Point(173, 45);
            cboTenKhachhang.Name = "cboTenKhachhang";
            cboTenKhachhang.Size = new Size(182, 31);
            cboTenKhachhang.TabIndex = 11;
            // 
            // button11
            // 
            button11.Location = new Point(392, 206);
            button11.Name = "button11";
            button11.Size = new Size(112, 34);
            button11.TabIndex = 9;
            button11.Text = "Ghi";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(970, 110);
            button10.Name = "button10";
            button10.Size = new Size(112, 34);
            button10.TabIndex = 8;
            button10.Text = "Sửa";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(970, 45);
            button9.Name = "button9";
            button9.Size = new Size(112, 34);
            button9.TabIndex = 7;
            button9.Text = "Thêm";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(896, 848);
            button8.Name = "button8";
            button8.Size = new Size(158, 34);
            button8.TabIndex = 6;
            button8.Text = "Hoàn thành";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(748, 848);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 5;
            button7.Text = "Hủy order";
            button7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 854);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 4;
            label6.Text = "20000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 854);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 3;
            label5.Text = "Tổng cộng";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { colOrderID, colLaptop, colGia, colSoLuong, colKhachHang, colKeToan, colSeller, colDate, colStatus });
            dgvOrder.Location = new Point(5, 290);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.Size = new Size(1140, 522);
            dgvOrder.TabIndex = 2;
            // 
            // colOrderID
            // 
            colOrderID.HeaderText = "Id";
            colOrderID.MinimumWidth = 6;
            colOrderID.Name = "colOrderID";
            colOrderID.Width = 125;
            // 
            // colLaptop
            // 
            colLaptop.HeaderText = "Laptop";
            colLaptop.MinimumWidth = 6;
            colLaptop.Name = "colLaptop";
            colLaptop.Width = 125;
            // 
            // colGia
            // 
            colGia.HeaderText = "Gía";
            colGia.MinimumWidth = 6;
            colGia.Name = "colGia";
            colGia.Width = 125;
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.Width = 125;
            // 
            // colKhachHang
            // 
            colKhachHang.HeaderText = "Khách Hàng";
            colKhachHang.MinimumWidth = 6;
            colKhachHang.Name = "colKhachHang";
            colKhachHang.Width = 125;
            // 
            // colKeToan
            // 
            colKeToan.HeaderText = "Kế Toán";
            colKeToan.MinimumWidth = 6;
            colKeToan.Name = "colKeToan";
            colKeToan.Width = 125;
            // 
            // colSeller
            // 
            colSeller.HeaderText = "Seller";
            colSeller.MinimumWidth = 6;
            colSeller.Name = "colSeller";
            colSeller.Width = 125;
            // 
            // colDate
            // 
            colDate.HeaderText = "Ngày Order";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.Width = 125;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 106);
            label4.Name = "label4";
            label4.Size = new Size(40, 23);
            label4.TabIndex = 1;
            label4.Text = "SĐT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 51);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 0;
            label3.Text = "Khách Hàng";
            // 
            // SellGUI_menu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 944);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "SellGUI_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bán hàng";
            Load += SellGUI_menu_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private Button button3;
        private Button btnOrder;
        private Button btnCustomer;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Button btnSanPham;
        private Button btnGhi;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private DataGridView dgvKhachHang;
        private TextBox txbName;
        private TextBox txbID;
        private Label label2;
        private Label label1;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label label6;
        private Label label5;
        private DataGridView dgvOrder;
        private Label label4;
        private Label label3;
        private TextBox txbSDT;
        private Label label7;
        private ComboBox txbTenLaptop;
        private ComboBox cboTenKhachhang;
        private Button button11;
        private Button button13;
        private Button button14;
        private TextBox txbAddress;
        private TextBox txbPhone;
        private Label label9;
        private Label label8;
        private Button btnHuy;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAddress;
        private TextBox txbTimKiem;
        private Button btnTimKiem;
        private ComboBox cboTimKiem;
        private CheckBox cbTimKiem;
        private TextBox txbSoLuong;
        private Label label10;
        private Button btnSuaOrder;
        private Button btnThemOrder;
        private DataGridViewTextBoxColumn colOrderID;
        private DataGridViewTextBoxColumn colLaptop;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colKhachHang;
        private DataGridViewTextBoxColumn colKeToan;
        private DataGridViewTextBoxColumn colSeller;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colStatus;
    }
}