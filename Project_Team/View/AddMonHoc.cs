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
    public partial class AddMonHoc : MaterialSkin.Controls.MaterialForm
    {
        public AddMonHoc()
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

        private void btClear_Click(object sender, EventArgs e)
        {
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (ThieuThongTin())
            {
                MessageBox.Show("Thiếu thông tin");
            }
            else
            {
                MonHoc monHoc = new MonHoc
                {
                    MaMonHoc = txtMaMonHoc.Text,
                    TenMonHoc = txtTenMonHoc.Text,
                    TinChi = Convert.ToInt32(numbTinChi.Value)
                };
                if (MainForm.BLL.Add_MonHoc_BLL(monHoc))
                {
                    MessageBox.Show("Thêm môn học thành công");
                }
                else MessageBox.Show("Đã có môn học này");
            }
        }

        private bool ThieuThongTin()
        {
            if (string.IsNullOrWhiteSpace(txtMaMonHoc.Text) || string.IsNullOrWhiteSpace(txtTenMonHoc.Text))
            {
                return true;
            }

            else return false;
        }
    }
}
