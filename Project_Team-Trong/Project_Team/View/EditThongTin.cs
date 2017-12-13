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
    public partial class EditThongTin : MaterialSkin.Controls.MaterialForm
    {
        public int MaSinhVien { get; set; }
        public EditThongTin(int mssv)
        {
            InitializeComponent();
            MaSinhVien = mssv;
            load_cB();
            setThongTin();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }
        public void load_cB()
        {
            //cBQueQuan.DataSource = MainForm.BLL.Get_ListQueQuan_BLL();
            cbNienKhoa.DataSource = MainForm.BLL.Get_ListNienKhoa_BLL();
            cbTenKhoa.DataSource = MainForm.BLL.Get_ListTenKhoa_BLL();
            cbTenLop.DataSource = MainForm.BLL.Get_ListLop_BLL();
        }
        public void setThongTin()
        {
            txtMaSinhVien.Text = "" + MaSinhVien;
            SinhVien sv = MainForm.BLL.Get_SV_BLL(MaSinhVien);
            txtTenSinhVien.Text = sv.TenSinhVien;
            cBQueQuan.SelectedIndex = cBQueQuan.FindStringExact(sv.QueQuan);
            dTNgaySinh.Value = sv.NgaySinh;
            if (sv.GioiTinh) rBNam.Checked = true; else rBNu.Checked = true;
            cbTenKhoa.SelectedIndex = cbTenKhoa.FindStringExact(sv.lops.Khoa.TenKhoa);
            cbTenLop.SelectedIndex = cbTenLop.FindStringExact(sv.lops.TenLop);
            cbNienKhoa.SelectedIndex = cbNienKhoa.FindStringExact(sv.NienKhoa.ToString());
            if (sv.TotNghiep) rBDaTN.Checked = true; else rBChuaTN.Checked = true;
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            if (ThieuThongTin())
            {
                MessageBox.Show("Thiếu thông tin");
            }
            else
            {
                SinhVien sv = new SinhVien();
                sv.MaSinhVien = MaSinhVien;
                sv.TenSinhVien = txtTenSinhVien.Text.Trim();
                sv.NgaySinh = dTNgaySinh.Value;
                sv.QueQuan = cBQueQuan.SelectedItem.ToString();
                sv.GioiTinh = rBNam.Checked;
                sv.NienKhoa = Int32.Parse(cbNienKhoa.SelectedItem.ToString());
                sv.MaLop = MainForm.BLL.Get_MaLop_BLL(cbTenLop.SelectedItem.ToString());
                sv.TotNghiep = rBDaTN.Checked;
                MainForm.BLL.Edit_ThongTin_BLL(sv);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            setThongTin();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ThieuThongTin()
        {
            if (string.IsNullOrWhiteSpace(txtMaSinhVien.Text) || string.IsNullOrWhiteSpace(txtTenSinhVien.Text) || string.IsNullOrWhiteSpace(cbNienKhoa.Text))
            {
                return true;
            }
            else return false;
        }
    }
}
