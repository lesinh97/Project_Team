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
    public partial class EditDiem : MaterialSkin.Controls.MaterialForm
    {
        public delegate void Diem(KetQua s);
        public Diem ed1;
        public EditDiem()
        {
            InitializeComponent();
            loadTenMonHoc();
            loadTenSinhVien();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }
        public void loadTenSinhVien()
        {

        }
        public void loadTenMonHoc()
        {

        }
        private void btEditOk_Click(object sender, EventArgs e)
        {
            KetQua kq = new KetQua();
            kq.DiemBaiTap = Double.Parse(tBDiemCC.Text);
            kq.DiemGiuaKi = Double.Parse(tBDiemGK.Text);
            kq.DiemCuoiKi = Double.Parse(tBDiemCK.Text);
            ed1.Invoke(kq);
        }
        //////////////////////////////////////////////////////////////////////
    }
}
