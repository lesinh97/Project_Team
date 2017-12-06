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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
