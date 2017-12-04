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
    public partial class VIew : Form
    {
        public Manager db;
        public VIew()
        {
            InitializeComponent();
            db = new Manager();
            dataGridView1.DataSource = db.SinhViens.Select(p => new {p.MaSinhVien}).ToList();
        }
    }
}
