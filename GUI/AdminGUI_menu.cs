﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;

namespace GUI
{
    public partial class AdminGUI_menu : Form
    {
        private Staff staff = new();
        private Staff user = new();

        public AdminGUI_menu(Staff user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void tab1Reset()
        {
            tabControl1.SelectedIndex = 1;
        }
        #region tab0
        #region LoadingEvent
        //Xu ly loading
        private void AdminGUI_menu_Load(object sender, EventArgs e)
        {
            tab0Reset();
            cbTimKiem.SelectedIndex = 0;
        }
        private void tab0Reset()
        {
            cbTimKiem.Enabled = true;
            tbTimKiem1.Enabled = true;
            tbHoTen.Enabled = false;
            tbID.Enabled = false;
            tbMatKhau.Enabled = false;
            tbTaiKhoan.Enabled = false;
            cbRole.Enabled = false;
            btnGhi1.Enabled = false;
            btnHuy1.Enabled = false;
            btnSua1.Enabled = true;
            btnXoa1.Enabled = true;
            btnThem1.Enabled = true;
            tbMatKhau.UseSystemPasswordChar = true;
            tbTaiKhoan.UseSystemPasswordChar = true;
            tabControl1.SelectedIndex = 0;
            dataGridView1.Enabled = true;
            dataGridView1.Rows.Clear();

            foreach (Staff item in StaffBUS.Instance.get())
            {
                if (item.RoleInt == 0 || item.ID == user.ID) continue;
                if (cbTimKiem.Text == "Chức vụ" || item.RoleString == cbTimKiem.Text)
                    if (tbTimKiem1.Text == "" || Search.Instance.ContainsString(item.Name, tbTimKiem1.Text))
                    {
                       // MessageBox.Show(Convert.ToString(Search.Instance.ContainsString(item.Name, tbTimKiem1.Text)));
                        dataGridView1.Rows.Add(item.ID, item.Name, item.RoleString, item.Username, item.Password);
                    }

            }
            DataGridViewRow row = dataGridView1.Rows[0];
            if (Convert.ToString(row.Cells["Column1"].Value) != "")
            {
                tbID.Text = Convert.ToString(row.Cells["Column1"].Value);
                tbHoTen.Text = Convert.ToString(row.Cells["Column2"].Value);
                tbTaiKhoan.Text = Convert.ToString(row.Cells["Column3"].Value);
                tbMatKhau.Text = Convert.ToString(row.Cells["Column4"].Value);
                cbRole.Text = Convert.ToString(row.Cells["Column5"].Value);
            }
        }

        #endregion

        #region ClickEvent
        //Xu ly cac event click
        private void btnQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            tab0Reset();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            tab1Reset();
        }
        private void btnShowLogInfo_Click(object sender, EventArgs e)
        {

            tbMatKhau.UseSystemPasswordChar = false;
            tbTaiKhoan.UseSystemPasswordChar = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbMatKhau.UseSystemPasswordChar = true;
                tbTaiKhoan.UseSystemPasswordChar = true;
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                if (Convert.ToString(row.Cells["Column1"].Value) != "")
                {
                    tbID.Text = Convert.ToString(row.Cells["Column1"].Value);
                    tbHoTen.Text = Convert.ToString(row.Cells["Column2"].Value);
                    tbTaiKhoan.Text = Convert.ToString(row.Cells["Column3"].Value);
                    tbMatKhau.Text = Convert.ToString(row.Cells["Column4"].Value);
                    cbRole.Text = Convert.ToString(row.Cells["Column5"].Value);
                }
            }
            catch
            {

            }
        }
        private void btnThem1_Click(object sender, EventArgs e)
        {
            if (btnSua1.Enabled == true)
            {
                cbTimKiem.Enabled = false;
                tbTimKiem1.Enabled = false;
                dataGridView1.Enabled = false;
                tbHoTen.Enabled = true;
                cbRole.Enabled = true;
                btnGhi1.Enabled = true;
                btnHuy1.Enabled = true;
                btnSua1.Enabled = false;
                btnXoa1.Enabled = false;
                tbID.Text = "";
                tbHoTen.Text = "";
                tbTaiKhoan.Text = "********";
                tbMatKhau.Text = "********";
                cbRole.Text = "";
            }
        }
        private void btnSua1_Click(object sender, EventArgs e)
        {
            if (btnThem1.Enabled == true)
            {
                cbTimKiem.Enabled = false;
                tbTimKiem1.Enabled = false;
                dataGridView1.Enabled = false;
                tbHoTen.Enabled = true;
                cbRole.Enabled = true;
                tbTaiKhoan.Enabled = false;
                tbMatKhau.Enabled = true;
                btnGhi1.Enabled = true;
                btnHuy1.Enabled = true;
                //btnSua1.Enabled = false;
                btnXoa1.Enabled = false;
                btnThem1.Enabled = false;
            }

        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportData.Instance.ToExcel(dataGridView1, "Danh sách tài khoản");
        }
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (StaffBUS.Instance.delete(staff))
                {
                    tab0Reset();
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
        private void btnGhi1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận ghi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (btnThem1.Enabled == true)
                {
                    if (tbHoTen.Text != "" && cbRole.Text != "")
                    {
                        tbMatKhau.Text = CreateUser.createPassword();
                        tbTaiKhoan.Text = CreateUser.createUsername(tbHoTen.Text);
                        if (StaffBUS.Instance.insert(staff))
                        {
                            tab0Reset();
                            MessageBox.Show("Đã ghi thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Ghi không thành công!");
                        }
                    }
                }
                else
                {
                    if (StaffBUS.Instance.update(staff))
                    {
                        tab0Reset();
                        MessageBox.Show("Đã ghi thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Ghi không thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ghi không thành công!");
            }
        }
        private void btnHuy1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tab0Reset();
            }
        }
        #endregion

        #region textChangeEvent
        //Hung du lieu cho staff
        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (tbID.Text.Length > 0)
            {
                staff.ID = Convert.ToInt32(tbID.Text);
            }
        }

        private void tbHoTen_TextChanged(object sender, EventArgs e)
        {
            staff.Name = tbHoTen.Text;
        }

        private void tbTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            staff.Username = tbTaiKhoan.Text;
        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {
            staff.Password = tbMatKhau.Text;
        }
        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            staff.RoleString = cbRole.Text;
        }
        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab0Reset();
        }
        
        private void tbTimKiem1_TextChanged(object sender, EventArgs e)
        {
            tab0Reset();
        }
        #endregion
        #endregion





    }
}
