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
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        public Manager_BLL BLL;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TabControl_Main.SelectTab(tabAdd);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TabControl_Main.SelectTab(tabSearch);
        }

        private void btEditDiem_Click(object sender, EventArgs e)
        {
            EditDiem f1 = new EditDiem();
            //f1.ed1 = new EditDiem.Diem(BLL.Edit_Diem_BLL);
            f1.Show();
        }

        private void btEditThongTin_Click(object sender, EventArgs e)
        {
            EditThongTin f2 = new EditThongTin();
            //f2.ed2 = new EditThongTin.ThongTin(BLL.Edit_ThongTin_BLL);
            f2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AddGiaoVien f = new AddGiaoVien();
            f.add = new AddGiaoVien.CNhiem(BLL.Add_ChuNhiem_BLL);
            f.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AddKhoa f = new AddKhoa();
            f.add = new AddKhoa.AKhoa(BLL.Add_Khoa_BLL);
            f.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        //////////////////////////////////////////////////////////////////////////////
    }
}
