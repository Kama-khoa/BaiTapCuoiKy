using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;

namespace GUI
{
    public partial class SellGUI_menu : Form
    {
        private Staff user = new();
        public SellGUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void SellGUI_menu_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

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

        }
    }
}
