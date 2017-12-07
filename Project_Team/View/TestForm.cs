using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team
{
    public partial class TestForm : Form
    {
        Manager_DAL dal;
        public TestForm()
        {
            dal = new Manager_DAL();
            InitializeComponent();
            dal.TinhDTB_TatCacMon_DAL();
            dataGridView1.DataSource = dal.ShowKetQua(); 
        }
    }
}
