using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AccGUI_menu : Form
    {
        private Staff user = new();
        public AccGUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        public void load()
        {
            dataGridView1.Enabled = true;
            dataGridView1.Rows.Clear();
            foreach (Order item in OrderBUS.Instance.GetOrders())
            {
                dataGridView1.Rows.Add(item.Order_id, item.Customer_name, item.Accoutant_name, item.Seller_name, item.Order_date, item.PaymentString);
            }
            DataGridViewRow row = dataGridView1.Rows[0];
            if (Convert.ToString(row.Cells["ID"].Value) != "")
            {
                tbID.Text = Convert.ToString(row.Cells["Column1"].Value);
                tbCus.Text = Convert.ToString(row.Cells["Column2"].Value);
                tbAcc.Text = Convert.ToString(row.Cells["Column3"].Value);
                tbSeller.Text = Convert.ToString(row.Cells["Column4"].Value);
                cboPayment.Text = Convert.ToString(row.Cells["Column5"].Value);
                dtpOrder.Text = Convert.ToDateTime(row.Cells["Column6"].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
