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
        


        //Tab login

        private void QuitBUT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okBUT_Click(object sender, EventArgs e)
        {
            if (BLL.loginCheck_BLL(LoginID, PassLogin))
            {
                this.Hide();
            }
            
        }

        private void PassLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (BLL.loginCheck_BLL(LoginID, PassLogin))
                {
                    this.Hide();
                }
            }
        } // Catch envents nhấn phím enter sau khi gõ mật khẩu xong

        private void RegisterBut_Click_1(object sender, EventArgs e)
        {
            TabControlWelcome.SelectTab(tabRegisrer);
            
        }


        //tab REgister

        private void CancleBUT_Click(object sender, EventArgs e)
        {
            TabControlWelcome.SelectTab(tabLogin);
        }

       
        private void clear_BUT_Click(object sender, EventArgs e)
        {
           BLL.clearBOX_BLL(newID_BOX,newPass_BOX);
        }

       
        private void OkBUT_newRegis_Click(object sender, EventArgs e)
        {
            if (BLL.newRegis_BLL(newID_BOX, newPass_BOX))
            {
               TabControlWelcome.SelectTab(tabLogin);
            }
        }

        private void newPass_BOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (BLL.newRegis_BLL(newID_BOX, newPass_BOX))
                {
                    TabControlWelcome.SelectTab(tabLogin);
                }
            }
        } // Catch envents nhấn phím enter sau khi gõ mật khẩu xong
        ////////////////////////////////////////////////////////////////////////////////
    }
}
