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
    public partial class AddGiaoVien : MaterialSkin.Controls.MaterialForm
    {
        public delegate bool CNhiem(ChuNhiem giaoVien);
        public  CNhiem add;
        public AddGiaoVien()
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
            ChuNhiem giaoVien = new ChuNhiem();
            giaoVien.MaGiaoVien = txtMaGiaoVien.Text;
            giaoVien.TenGiaoVien = txtTenGiaoVien.Text;
            add.Invoke(giaoVien);
        }
    }
}
