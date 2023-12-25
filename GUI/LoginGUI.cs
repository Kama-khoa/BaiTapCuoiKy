using BUS;
using DAL;
using DTO;

namespace GUI
{
    public partial class LoginGUI : Form
    {
        private Staff user = new();
        public LoginGUI()
        {
            InitializeComponent();
        }
        #region clickEvent
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (StaffBUS.Instance.checkLogInfo(user)==true)
            {
                this.Hide();
                userRole();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
            }
        }
        #endregion
        #region loadEvent
        private void LoginGUI_Load(object sender, EventArgs e)
        {
            passwordTextbox.UseSystemPasswordChar = true;

        }
        private void userRole()
        {
            foreach (Staff item in StaffDAL.Instance.get())
            {
                if (user.Username == item.Username && user.Password == item.Password)
                {
                    user = item;
                }
            }
            switch (user.RoleInt)
            {
                case 0:
                    ManagerGUI_menu menu0 = new(user);
                    menu0.ShowDialog();
                    break;
                case 1:
                    SellGUI_menu menu1 = new(user);
                    menu1.ShowDialog();
                    break;
                case 2:
                    AccGUI_menu menu2 = new(user);
                    menu2.ShowDialog();
                    break;
                case 3:
                    SellGUI_menu menu3 = new(user);
                    menu3.ShowDialog();
                    break;
                case 4:
                    SellGUI_menu menu4 = new(user);
                    menu4.ShowDialog();
                    break;
            }

        }
        #endregion
        #region textChangeEvent
        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            user.Username = usernameTextbox.Text;
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            user.Password = passwordTextbox.Text;
        }
        
        #endregion
    }
}