using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Project_Team
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Manager_BLL BLL;
        public Login()
        {
            InitializeComponent();
            // Tạo control của Material

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            BLL = new Manager_BLL();
        }
        // Các hàm chức năng

        private void loginCheck()
        {
            int id = Int32.Parse(LoginID.Text);
            string pass = PassLogin.Text;
            if (BLL.DangNhap_BLL(id, pass))
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                clearBOX_login();
            }
        }
        private void clearBOX()
        {
            newID_BOX.Clear();
            newPass_BOX.Clear();
        }
        private void newRegister()
        {
            Users us = new Users();
            us.ID = Int32.Parse(newID_BOX.Text);
            us.Pass = newPass_BOX.Text;
            if (BLL.Add_User_BLL(us))
            {
                MessageBox.Show("Thêm thành công người dùng mới");
                this.Close();
            }
            else
            {
                clearBOX();
            }
        }
        private void clearBOX_login()
        {
            LoginID.Clear();
            PassLogin.Clear();
        }


        //Tab login

        private void QuitBUT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okBUT_Click(object sender, EventArgs e)
        {
            loginCheck();
        }

        private void PassLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginCheck();
            }
        } // Catch envents nhấn phím enter sau khi gõ mật khẩu xong

        private void RegisterBut_Click_1(object sender, EventArgs e)
        {
            TabControlWelcome.SelectTab(tabRegisrer);
            clearBOX_login();
        }


        //tab REgister

        private void CancleBUT_Click(object sender, EventArgs e)
        {
            TabControlWelcome.SelectTab(tabLogin);
        }

       
        private void clear_BUT_Click(object sender, EventArgs e)
        {
            clearBOX();
        }

       
        private void OkBUT_newRegis_Click(object sender, EventArgs e)
        {
            newRegister();
        }

        private void newPass_BOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newRegister();
            }
        } // Catch envents nhấn phím enter sau khi gõ mật khẩu xong
    }
}
