namespace GUI
{
    partial class AccGUI_menu
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
            btCho = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnCustomer = new Button();
            tabPage3 = new TabPage();
            dtpOrder = new DateTimePicker();
            tbSeller = new TextBox();
            tbAcc = new TextBox();
            tbCus = new TextBox();
            label13 = new Label();
            label5 = new Label();
            label11 = new Label();
            label10 = new Label();
            tbID = new TextBox();
            label4 = new Label();
            cboPayment = new ComboBox();
            button8 = new Button();
            button7 = new Button();
            label6 = new Label();
            lb5 = new Label();
            label12 = new Label();
            dataGridView2 = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            AccoutantID = new DataGridViewTextBoxColumn();
            SellerID = new DataGridViewTextBoxColumn();
            OrderTime = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewTextBoxColumn();
            label3 = new Label();
            tabPage2 = new TabPage();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label14 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btCho);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnCustomer);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 943);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // btCho
            // 
            btCho.Location = new Point(0, 288);
            btCho.Name = "btCho";
            btCho.Size = new Size(323, 83);
            btCho.TabIndex = 4;
            btCho.Text = "Order đang chờ";
            btCho.UseVisualStyleBackColor = true;
            btCho.Click += button1_Click;
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
            // btnCustomer
            // 
            btnCustomer.Location = new Point(0, 377);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(323, 83);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Hóa đơn";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(dtpOrder);
            tabPage3.Controls.Add(tbSeller);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(tbAcc);
            tabPage3.Controls.Add(tbCus);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(tbID);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(cboPayment);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(lb5);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1145, 913);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtpOrder
            // 
            dtpOrder.Format = DateTimePickerFormat.Short;
            dtpOrder.Location = new Point(663, 73);
            dtpOrder.Name = "dtpOrder";
            dtpOrder.Size = new Size(119, 25);
            dtpOrder.TabIndex = 18;
            // 
            // tbSeller
            // 
            tbSeller.Location = new Point(137, 184);
            tbSeller.Name = "tbSeller";
            tbSeller.Size = new Size(192, 25);
            tbSeller.TabIndex = 17;
            // 
            // tbAcc
            // 
            tbAcc.Location = new Point(137, 127);
            tbAcc.Name = "tbAcc";
            tbAcc.Size = new Size(192, 25);
            tbAcc.TabIndex = 17;
            // 
            // tbCus
            // 
            tbCus.Location = new Point(137, 73);
            tbCus.Name = "tbCus";
            tbCus.Size = new Size(192, 25);
            tbCus.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 187);
            label13.Name = "label13";
            label13.Size = new Size(44, 19);
            label13.TabIndex = 15;
            label13.Text = "Seller:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 130);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 15;
            label5.Text = "Kế toán:";
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(41, 76);
            label11.Name = "label11";
            label11.Size = new Size(134, 23);
            label11.TabIndex = 15;
            label11.Text = "Khách hàng:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 99);
            label10.Name = "label10";
            label10.Size = new Size(0, 19);
            label10.TabIndex = 14;
            // 
            // tbID
            // 
            tbID.Location = new Point(137, 27);
            tbID.Name = "tbID";
            tbID.Size = new Size(192, 25);
            tbID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 27);
            label4.Name = "label4";
            label4.Size = new Size(26, 19);
            label4.TabIndex = 12;
            label4.Text = "ID:";
            // 
            // cboPayment
            // 
            cboPayment.FormattingEnabled = true;
            cboPayment.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            cboPayment.Location = new Point(663, 27);
            cboPayment.Name = "cboPayment";
            cboPayment.Size = new Size(119, 25);
            cboPayment.TabIndex = 11;
            // 
            // button8
            // 
            button8.Location = new Point(983, 833);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 6;
            button8.Text = "xong";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(835, 833);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 5;
            button7.Text = "hủy đơn";
            button7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 842);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(41, 842);
            lb5.Name = "lb5";
            lb5.Size = new Size(38, 19);
            lb5.TabIndex = 3;
            lb5.Text = "tổng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(487, 76);
            label12.Name = "label12";
            label12.Size = new Size(84, 19);
            label12.TabIndex = 0;
            label12.Text = "Ngày tháng:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { OrderID, CustomerID, AccoutantID, SellerID, OrderTime, Payment });
            dataGridView2.Location = new Point(5, 290);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(1140, 522);
            dataGridView2.TabIndex = 2;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "ID";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.Width = 125;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Khách hàng";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 125;
            // 
            // AccoutantID
            // 
            AccoutantID.HeaderText = "Kế toán";
            AccoutantID.MinimumWidth = 6;
            AccoutantID.Name = "AccoutantID";
            AccoutantID.Width = 125;
            // 
            // SellerID
            // 
            SellerID.HeaderText = "Seller";
            SellerID.MinimumWidth = 6;
            SellerID.Name = "SellerID";
            SellerID.Width = 125;
            // 
            // OrderTime
            // 
            OrderTime.HeaderText = "Ngày tháng";
            OrderTime.MinimumWidth = 6;
            OrderTime.Name = "OrderTime";
            OrderTime.Width = 125;
            // 
            // Payment
            // 
            Payment.HeaderText = "Phương thức thanh toán";
            Payment.MinimumWidth = 6;
            Payment.Name = "Payment";
            Payment.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 27);
            label3.Name = "label3";
            label3.Size = new Size(163, 19);
            label3.TabIndex = 0;
            label3.Text = "Phương thức thanh toán:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1145, 915);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 25);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 25);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 20);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // button5
            // 
            button5.Location = new Point(810, 34);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 3;
            button5.Text = "xuất hóa đơn";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 290);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1140, 604);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(324, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1153, 943);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1145, 915);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(506, 830);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(156, 110);
            label9.Name = "label9";
            label9.Size = new Size(45, 19);
            label9.TabIndex = 2;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(280, 261);
            label8.Name = "label8";
            label8.Size = new Size(45, 19);
            label8.TabIndex = 1;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(267, 464);
            label7.Name = "label7";
            label7.Size = new Size(45, 19);
            label7.TabIndex = 0;
            label7.Text = "label7";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(590, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 25);
            textBox3.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(487, 168);
            label14.Name = "label14";
            label14.Size = new Size(67, 19);
            label14.TabIndex = 15;
            label14.Text = "Tìm kiếm:";
            // 
            // button1
            // 
            button1.Location = new Point(696, 833);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AccGUI_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 944);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AccGUI_menu";
            Text = "AccGUI_payment";
            Load += button1_Click;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btCho;
        private PictureBox pictureBox1;
        private Button button3;
        private Button btnCustomer;
        private TabPage tabPage3;
        private ComboBox cboPayment;
        private Button button8;
        private Button button7;
        private Label label6;
        private Label lb5;
        private DataGridView dataGridView2;
        private Label label3;
        private TabPage tabPage2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button5;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button2;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox tbAcc;
        private TextBox tbCus;
        private Label label11;
        private Label label10;
        private TextBox tbID;
        private Label label4;
        private TextBox tbSeller;
        private Label label12;
        private DateTimePicker dtpOrder;
        private Label label13;
        private Label label5;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn AccoutantID;
        private DataGridViewTextBoxColumn SellerID;
        private DataGridViewTextBoxColumn OrderTime;
        private DataGridViewTextBoxColumn Payment;
        private Button button1;
        private TextBox textBox3;
        private Label label14;
    }
}