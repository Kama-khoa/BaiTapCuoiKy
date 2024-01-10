using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        private int id;
        private string name;
        private string username;
        private string password;
        private int roleInt;
        private string roleString;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        { 
            get { return name; } 
            set {  name = value; } 
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public int RoleInt
        {
            get { return roleInt; }
            set { roleInt = value; setRoleString(); }
        }
        public string RoleString
        {
            get { return roleString; }
            set { roleString = value; setRoleInt(); }
        }
        private void setRoleString()
        {
            switch (roleInt)
            {
                case 0:
                    roleString = "Quản lý"; 
                    break;
                case 1:
                    roleString = "Nhân viên bán hàng";
                    break;
                case 2:
                    roleString = "Kế toán";
                    break;
                case 3:
                    roleString = "Thủ kho";
                    break;
                case 4:
                    roleString = "Nhân viên chăm sóc khách hàng";
                    break;
            }
        }
        private void setRoleInt()
        {
            switch (roleString)
            {
                case "Admin":
                    roleInt = 0;
                    break;
                case "Nhân viên bán hàng":
                    roleInt = 1;
                    break;
                case "Kế toán":
                    roleInt = 2;
                    break;
                case "Thủ kho":
                    roleInt = 3;
                    break;
                case "Nhân viên chăm sóc khách hàng":
                    roleInt = 4;
                    break;
            }
        }

    }
}
