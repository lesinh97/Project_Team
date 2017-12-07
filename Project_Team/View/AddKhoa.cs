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
    public partial class AddKhoa : MaterialSkin.Controls.MaterialForm
    {
        public delegate bool AKhoa(Khoa khoaMoi);
        public AKhoa add;
        public AddKhoa()
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

        private void btOk_Click(object sender, EventArgs e)
        {
            Khoa khoaMoi = new Khoa();
            khoaMoi.MaKhoa = txtMaKhoa.Text;
            khoaMoi.TenKhoa = txtTenKhoa.Text;
            add.Invoke(khoaMoi);
        }
    }
}
