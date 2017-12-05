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
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            BLL = new Manager_BLL();
        }

        private void RegisterBut_Click(object sender, EventArgs e)
        {
            addUserForm addUserForm = new addUserForm();
            addUserForm.Show();
        }
        private void okBUT_Click(object sender, EventArgs e)
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
            }
        }

        private void QuitBUT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
