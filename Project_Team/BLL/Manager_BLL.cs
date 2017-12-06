using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class Manager_BLL
    {
        public Manager_DAL DAL;
        public Manager_BLL()
        {
            DAL = new Manager_DAL();
        }

        public bool Add_User_BLL(Users us)
        {
            return DAL.Add_User_DAL(us);
        }
        public bool DangNhap_BLL(int id, string pass)
        {
            return DAL.DangNhap_DAL(id, pass);
        }
    }
}
