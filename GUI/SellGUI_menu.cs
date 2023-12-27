using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;

namespace GUI
{
    public partial class SellGUI_menu : Form
    {
        private Customer customer = new Customer();
        private Staff user = new();
        string state = null;
        private Order order = new Order();

        public SellGUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        #region LoadingEvent
        private void LoadingCustomer()
        {

            foreach (Customer item in CustomerBUS.Instance.get())
            {

                dgvKhachHang.Rows.Add(item.ID, item.Name, item.Phone, item.Address);
            }
            DataGridViewRow row = dgvKhachHang.Rows[0];
            if (Convert.ToString(row.Cells["colID"].Value) != "")
            {
                txbID.Text = Convert.ToString(row.Cells["colID"].Value);
                txbName.Text = Convert.ToString(row.Cells["colName"].Value);
                txbPhone.Text = Convert.ToString(row.Cells["colPhone"].Value);
                txbAddress.Text = Convert.ToString(row.Cells["colAddress"].Value);
            }
        }
       /* private void LoadingOrder()
        {

            foreach (Order item in OrderBUS.Instance.get())
            {

                dgvOrder.Rows.Add(item.Order_ID, item.Laptop_ID, item.Price, item.Quantity, item.Customer_ID, item.Accountant_ID, item.Seller_ID, item.DATE, item.STATUS);
            }
        }*/
        #endregion

        private void SellGUI_menu_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            LoadingCustomer();
            //LoadingOrder();
            state = "Start";
            ManageInterface(state);
            cbTimKiem_CheckedChanged(sender, e);
        }
        #region ClickEvent
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKhachHang.Rows[e.RowIndex];
            if (Convert.ToString(row.Cells["colID"]) != null)
            {
                txbID.Text = Convert.ToString(row.Cells["colID"].Value);
                txbName.Text = Convert.ToString(row.Cells["colName"].Value);
                txbPhone.Text = Convert.ToString(row.Cells["colPhone"].Value);
                txbAddress.Text = Convert.ToString(row.Cells["colAddress"].Value);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = "Add";
            ManageInterface(state);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            state = "Update";
            ManageInterface(state);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CustomerBUS.Instance.delete(customer);
                this.dgvKhachHang.DataSource = null;
                this.dgvKhachHang.Rows.Clear();
                LoadingCustomer();
                ManageInterface("Start");
            }
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                if (txbName.Text != "" && txbPhone.Text != "" && txbAddress.Text != "")
                {
                    if (CustomerBUS.Instance.CheckPhone(customer) == true)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại");
                    }
                    else
                    {
                        CustomerBUS.Instance.insert(customer);
                        this.dgvKhachHang.DataSource = null;
                        this.dgvKhachHang.Rows.Clear();
                        LoadingCustomer();
                        MessageBox.Show("Thêm thông tin thành công", "Thông báo");
                        ManageInterface("Start");
                    }
                }
                else
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo");
                }
            }
            if (state == "Update")
            {
                if (txbName.Text != "" && txbPhone.Text != "" && txbAddress.Text != "")
                {
                    CustomerBUS.Instance.update(customer);
                    this.dgvKhachHang.DataSource = null;
                    this.dgvKhachHang.Rows.Clear();
                    LoadingCustomer();
                    MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                    ManageInterface("Start");
                }
                else
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!", "Thông báo");
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbName.Text = "";
            txbPhone.Text = "";
            txbAddress.Text = "";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "ID")
            {
                this.dgvKhachHang.DataSource = null;
                this.dgvKhachHang.Rows.Clear();

                foreach (Customer item in CustomerBUS.Instance.get())
                {
                    if (item.ID == Convert.ToInt32(txbTimKiem.Text))
                    {
                        dgvKhachHang.Rows.Add(item.ID, item.Name, item.Phone, item.Address);
                    }
                }
            }
            else if (cboTimKiem.Text == "Tên")
            {
                this.dgvKhachHang.DataSource = null;
                this.dgvKhachHang.Rows.Clear();

                foreach (Customer item in CustomerBUS.Instance.get())
                {
                    if (item.Name == txbTimKiem.Text)
                    {
                        dgvKhachHang.Rows.Add(item.ID, item.Name, item.Phone, item.Address);
                    }
                }
            }
            else
            {
                this.dgvKhachHang.DataSource = null;
                this.dgvKhachHang.Rows.Clear();

                foreach (Customer item in CustomerBUS.Instance.get())
                {
                    if (item.Phone == txbTimKiem.Text)
                    {
                        dgvKhachHang.Rows.Add(item.ID, item.Name, item.Phone, item.Address);
                    }
                }
            }
        }

        private void cbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimKiem.Checked == true)
            {
                btnTimKiem.Visible = true;
                txbTimKiem.Visible = true;
                cboTimKiem.Visible = true;
            }
            else
            {
                LoadingCustomer();
                btnTimKiem.Visible = false;
                txbTimKiem.Visible = false;
                cboTimKiem.Visible = false;
            }
        }
        #endregion
        public void ManageInterface(string state)
        {
            switch (state)
            {
                case "Start":
                    txbID.Enabled = false;
                    txbName.Enabled = false;
                    txbPhone.Enabled = false;
                    txbAddress.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnGhi.Enabled = false;
                    break;
                case "Add":
                    txbID.Enabled = false;
                    txbName.Enabled = true;
                    txbPhone.Enabled = true;
                    txbAddress.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnGhi.Enabled = true;
                    break;
                case "Update":
                    txbID.Enabled = false;
                    txbName.Enabled = true;
                    txbPhone.Enabled = true;
                    txbAddress.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnGhi.Enabled = true;
                    break;
                case "Delete":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnGhi.Enabled = true;
                    break;
            }
        }

        #region TextChangeEvent
        private void txbID_TextChanged(object sender, EventArgs e)
        {
            if (txbID.Text.Length > 0)
            {
                customer.ID = Convert.ToInt32(txbID.Text);
            }
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            customer.Name = txbName.Text;
        }

        private void txbPhone_TextChanged(object sender, EventArgs e)
        {
            customer.Phone = txbPhone.Text;
        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {
            customer.Address = txbAddress.Text;
        }
        #endregion

    }
}
