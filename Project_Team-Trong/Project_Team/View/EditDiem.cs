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
        public int MaSinhVien { get; set; }
        public EditDiem(int mssv)
        {
            InitializeComponent();
            MaSinhVien = mssv;
            loadMaMonHoc();
            setThongTin(MaSinhVien);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }
        public void setThongTin(int ms)
        {
            txtMaSinhVien.Text = ""+ms;
            txtTenSinhVien.Text = MainForm.BLL.Get_SV_BLL(ms).TenSinhVien;
        }
        public void loadMaMonHoc()
        {
            cBMaMonHoc.DataSource = MainForm.BLL.Get_ListMaMonHoc_BLL(MaSinhVien);
        }
        private void cBMaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDiem();
        }
        public void getDiem()
        {
            string MaMonHoc = cBMaMonHoc.SelectedItem.ToString();
            KetQua kq = MainForm.BLL.Get_MotKetQua_BLL(MaMonHoc, MaSinhVien);
            // Chuyển từ double sang decimal vì value ở dạng decimal
            numbChuyenCan.Value = Convert.ToDecimal(kq.DiemBaiTap);
            numbGiuaKi.Value = Convert.ToDecimal(kq.DiemGiuaKi);
            numbCuoiKi.Value = Convert.ToDecimal(kq.DiemCuoiKi);
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            KetQua kq = new KetQua();
            kq.MaSinhVien = 1;
            kq.MaMonHoc = cBMaMonHoc.SelectedItem.ToString();
            // Value ở dạng decimal nên chuyển sang double
            kq.DiemBaiTap = Convert.ToDouble(numbChuyenCan.Value);
            kq.DiemGiuaKi = Convert.ToDouble(numbGiuaKi.Value);
            kq.DiemCuoiKi = Convert.ToDouble(numbCuoiKi.Value);
            MainForm.BLL.Edit_Diem_BLL(kq);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            getDiem();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
 
    }
}
