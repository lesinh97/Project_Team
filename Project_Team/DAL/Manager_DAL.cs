using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team
{
    public class Manager_DAL
    {
        public Manager db;

        public Manager_DAL()
        {
            db = new Manager();
        }


        public bool Add_User_DAL(Users us)
        {
            var s = db.Userses.Where(p => p.ID == us.ID).Select(p => p);
            if (s.Any())
            {
                MessageBox.Show("Đã có user này tồn tại");
                return false;
            }
            else
            {
                db.Userses.Add(us);
                db.SaveChanges();
                return true;
            }
            
        }

        public bool Add_MonHoc_DAL(MonHoc monHoc)
        {
            var s = db.MonHocs.Where(p => p.MaMonHoc.Equals(monHoc.MaMonHoc)).Select(p => p);
            if(s.Any())
            {
                MessageBox.Show("Đã có môn học này trong hệ thống");
                return false;
            }
            else
            {
                db.MonHocs.Add(monHoc);
                db.SaveChanges();
                return true;
            }
        }

        public bool DangNhap_DAL(int id, string Pass)
        {
            db = new Manager();
            var s = db.Userses.Where(p => p.ID == id && p.Pass == Pass).Select(p => p);
            return (s.Any());
        }
    }
}
