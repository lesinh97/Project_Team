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
    public partial class AddLop : MaterialSkin.Controls.MaterialForm
    {
        public AddLop()
        {
            InitializeComponent();
            loadMaKhoa();
            loadMaGV();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }
        public void loadMaKhoa()
        {
            cBMaKhoa.DataSource = MainForm.BLL.Get_ListMaKhoa_BLL();

        }
        public void loadMaGV()
        {
            cBMaGV.DataSource = MainForm.BLL.Get_ListMaChuNhiem_BLL();
        }

        public void text_Clear()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (ThieuThongTin())
            {
                MessageBox.Show("Thiếu thông tin");
            }
            else
            {
                Lop lopMoi = new Lop();
                lopMoi.MaLop = txtMaLop.Text;
                lopMoi.TenLop = txtTenLop.Text;
                lopMoi.MaKhoa = cBMaKhoa.SelectedItem.ToString();
                lopMoi.MaGiaoVien = cBMaGV.SelectedItem.ToString();
                if (MainForm.BLL.Add_Lop_BLL(lopMoi)) MessageBox.Show("Thêm lớp thành công");
                else MessageBox.Show("Đã có lớp này");
                text_Clear();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            text_Clear();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool ThieuThongTin()
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                return true;
            }
            else return false;
        }
    }
}
