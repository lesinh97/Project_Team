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
using Project_Team.View;

namespace Project_Team
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        public static Manager_BLL BLL;
        public int MaSinhVien_Edit;
        public string TenSinhVien_Edit;
        public MainForm()
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
            load_cB_Add();
            load_cB_Search();
            btEditDiem.Enabled = false;
            btEditThongTin.Enabled = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
 
        //private void clearBOX_newMonHoc()
        //{
        //    newIDMonHocTextB.Clear();
        //    NewTenMHBox.Clear();
        //    NewTinChi.Clear();
        //}
        //private void Save_themMH_Click(object sender, EventArgs e)
        //{
        //    MonHoc monHoc = new MonHoc();
        //    monHoc.MaMonHoc = newIDMonHocTextB.Text;
        //    monHoc.TenMonHoc = NewTenMHBox.Text;
        //    monHoc.TinChi = Int32.Parse(NewTinChi.Text);
        //    if (BLL.Add_MonHoc_BLL(monHoc))
        //    {
        //        MessageBox.Show("Thêm thành công môn học mới");
        //    }
        //    else
        //    {
        //        clearBOX_newMonHoc();
        //    }
        //}

        private void pictureBox_Add_Click(object sender, EventArgs e)
        {
            TabControl_Main.SelectTab(tabAdd);
        }
        private void pictureBox_Search_Click(object sender, EventArgs e)
        {
            TabControl_Main.SelectTab(tabSearch);
        }
        private void pictureBox_Khac_Click(object sender, EventArgs e)
        {
            TabControl_Main.SelectTab(tabKhac);
        }
        private void btEditDiem_Click(object sender, EventArgs e)
        {
            EditDiem f1 = new EditDiem(MaSinhVien_Edit);
            f1.Show();
        }

        private void btEditThongTin_Click(object sender, EventArgs e)
        {
            EditThongTin f2 = new EditThongTin(MaSinhVien_Edit);
            f2.Show();
        }

        private void pictureBox_Add_GV_Click(object sender, EventArgs e)
        {
            AddGiaoVien f = new AddGiaoVien();
            f.Show();
        }
        private void pictureBox_Add_Lop_Click(object sender, EventArgs e)
        {
            AddLop f = new AddLop();
            f.Show();
        }
        private void pictureBox_Add_Khoa_Click(object sender, EventArgs e)
        {
            AddKhoa f = new AddKhoa();
            f.Show();
        }
        private void pictureBox_Add_MonHoc_Click(object sender, EventArgs e)
        {
            AddMonHoc f = new AddMonHoc();
            f.Show();
        }
        public void load_cB_Add()
        {
            cBQueQuan.SelectedIndex = 14;
            cBNienKhoa.DataSource = BLL.Get_ListNienKhoa_BLL();
            cBTenKhoa.DataSource = BLL.Get_ListTenKhoa_BLL();
            cBTenLop.DataSource = BLL.Get_ListLop_BLL();
        }
        public void load_cB_Search()
        {
            cBSearchGVCN.DataSource = BLL.Get_ListChuNhiem_BLL();
            cBSearchGVCN.SelectedIndex = -1;
            cBSearchNienKhoa.DataSource = BLL.Get_ListNienKhoa_BLL();
            cBSearchNienKhoa.SelectedIndex = -1;
            cBSearchTenKhoa.DataSource = BLL.Get_ListTenKhoa_BLL();
            cBSearchTenKhoa.SelectedIndex = -1;
            cBSearchTenMonHoc.DataSource = BLL.Get_ListTenMonHoc_BLL();
            cBSearchTenMonHoc.SelectedIndex = -1;
            cBSearchTenLop.DataSource = BLL.Get_ListLop_BLL();
            cBSearchTenLop.SelectedIndex = -1;
        }
        public void SetSTT()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i+1;
            }
        }
        public void Set_null_dgv()
        {
            List<object> list = new List<object>(); 
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                list.Add("");
            }
            dataGridView1.DataSource = list;
        }
        private void bTSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string MaSinhVien = txtSearchMaSinhVien.Text.Trim();
            string TenSinhVien = txtSearchTenSinhVien.Text.Trim();
            string TenLop = cBSearchTenLop.SelectedIndex == -1 ? "" : cBSearchTenLop.SelectedItem.ToString();
            string TenKhoa = cBSearchTenKhoa.SelectedIndex == -1 ? "" : cBSearchTenKhoa.SelectedItem.ToString();
            string GVCN = cBSearchGVCN.SelectedIndex == -1 ? "" : cBSearchGVCN.SelectedItem.ToString();
            string MonHoc = cBSearchTenMonHoc.SelectedIndex == -1 ? "@" : cBSearchTenMonHoc.SelectedItem.ToString();
            List<SinhVien> list = BLL.Search_SV_BLL(MaSinhVien, TenSinhVien, TenLop, TenKhoa, GVCN, MonHoc);
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add(
                list[i].MaSinhVien,
                list[i].TenSinhVien,
                list[i].GioiTinh,
                list[i].NgaySinh,
                list[i].QueQuan,
                list[i].lops.TenLop,
                list[i].lops.Khoa.TenKhoa,
                list[i].TotNghiep);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btEditDiem.Enabled = false;
            btEditThongTin.Enabled = false;
            MaSinhVien_Edit = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if(BLL.Get_ListMaMonHoc_BLL(MaSinhVien_Edit).Any()) btEditDiem.Enabled = true;
            if(dataGridView1.SelectedRows.Count!=0) btEditThongTin.Enabled = true;
            MessageBox.Show("" + MaSinhVien_Edit);
        }
        public void clear_tab_Add()
        {
            load_cB_Add();
            txtMaSinhVien.Clear();
            txtTenSinhVien.Clear();
            dTNgaySinh.Value = DateTime.Now;
            rBNam.Checked = true;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (ThieuThongTin())
            {
                MessageBox.Show("Thiếu thông tin");
            }
            else
            {
                SinhVien sv = new SinhVien();
                sv.MaSinhVien = Int32.Parse(txtMaSinhVien.Text);
                sv.TenSinhVien = txtTenSinhVien.Text.Trim();
                sv.NgaySinh = dTNgaySinh.Value;
                sv.QueQuan = cBQueQuan.SelectedItem.ToString();
                sv.GioiTinh = rBNam.Checked;
                sv.NienKhoa = Int32.Parse(cBNienKhoa.Text);
                sv.MaLop = BLL.Get_MaLop_BLL(cBTenLop.SelectedItem.ToString());
                sv.TotNghiep = false;
                if (BLL.Add_SV_BLL(sv)) MessageBox.Show("Đã thêm thành công");
                else MessageBox.Show("Sinh viên đã tồn tại");
                clear_tab_Add();
                load_cB_Add();
            }
        }

        private void pictureBox_Excel_Click(object sender, EventArgs e)
        {
            Excel f = new Excel();
            f.Show();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            load_cB_Search();
            txtSearchMaSinhVien.Clear();
            txtSearchTenSinhVien.Clear();
        }
        private bool ThieuThongTin()
        {
            if (string.IsNullOrWhiteSpace(txtMaSinhVien.Text) || string.IsNullOrWhiteSpace(txtTenSinhVien.Text) || string.IsNullOrWhiteSpace(cBNienKhoa.Text))
            {
                return true;
            }
            else return false;
        }

       
    }
}
