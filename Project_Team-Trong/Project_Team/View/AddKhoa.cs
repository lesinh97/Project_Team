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

        public void text_Clear()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (ThieuThongTin())
            {
                MessageBox.Show("Thiếu thông tin");
            }
            else
            {
                Khoa khoaMoi = new Khoa();
                khoaMoi.MaKhoa = txtMaKhoa.Text;
                khoaMoi.TenKhoa = txtTenKhoa.Text;
                if (MainForm.BLL.Add_Khoa_BLL(khoaMoi) == false) MessageBox.Show("Đã có khoa này");
                else MessageBox.Show("Thêm khoa thành công");
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
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                return true;
            }
            else return false;
        }
    }
}
