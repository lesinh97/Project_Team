using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class Manager_DAL
    {
        public Manager db;

        public Manager_DAL()
        {
            db = new Manager();
        }

        public void Add_User_DAL(Users us)
        {
            db.Userses.Add(us);
            db.SaveChanges();
        }

        public bool DangNhap_DAL(int id, string Pass)
        {
            db = new Manager();
            var s = db.Userses.Where(p => p.ID == id && p.Pass == Pass).Select(p => p);
            return (s.Any());
        }
    }
}
