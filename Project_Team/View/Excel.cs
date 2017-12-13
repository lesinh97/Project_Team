using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team.View
{
    public partial class Excel : Form
    {
        Manager_BLL BLL;
        public Excel()
        {
            BLL = new Manager_BLL();
            InitializeComponent();
        }

        private void btPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel File|*.xls;*.xlsx";//chi lay file dinh dang xls hoac xlsx
            fileDialog.Filter = "Excel File|*.xls;*.xlsx";//chi lay file dinh dang xls hoac xlsx
            fileDialog.FilterIndex = 1;//tro vao vi tri dau tien cua bo loc
            fileDialog.RestoreDirectory = true;//nho duong dan truy cap dc
            fileDialog.Multiselect = false;//khong cho phep chon nhieu file cung luc
            fileDialog.Title = "Chon file Excel";//tieu de cua hop thoai
            //neu chon file thanh cong
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fileDialog.FileName;
            }
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            if (path == null)
            {
                MessageBox.Show("Chua chon file Excel", "Error");
            }
            else
            {
                BLL.ReadExcel_BLL(path);
                MessageBox.Show("Them thanh cong");
                txtPath.ResetText();
            }
        }
    }
}
