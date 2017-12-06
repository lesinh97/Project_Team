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
    public partial class addUserForm : MaterialSkin.Controls.MaterialForm
    {
        public Manager_BLL BLL;
        public addUserForm()
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

        private void clearBOX()
        {
            newIDBox.Clear();
            newPassBox.Clear();
        }

        private void ClearBUT_Click(object sender, EventArgs e)
        {
            clearBOX();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            us.ID = Int32.Parse(newIDBox.Text);
            us.Pass = newPassBox.Text;
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
    }
}
