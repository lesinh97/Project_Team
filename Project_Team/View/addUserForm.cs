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

namespace Project_Team.View
{
    public partial class addUserForm : MaterialSkin.Controls.MaterialForm
    {
        public Manager db { get; set; }
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
        }

        private void ClearBUT_Click(object sender, EventArgs e)
        {
            newIDBox.Text = "";
            newPassBox.Text = "";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            db = new Manager();
        }
    }
}
