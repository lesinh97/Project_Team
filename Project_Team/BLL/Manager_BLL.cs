using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

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

        public bool Add_MonHoc_BLL(MonHoc monHoc)
        {
            return DAL.Add_MonHoc_DAL(monHoc);
        }
        public bool DangNhap_BLL(int id, string pass)
        {
            return DAL.DangNhap_DAL(id, pass);
        }

        public bool loginCheck_BLL(MaterialSingleLineTextField a, MaterialSingleLineTextField b)
        {
             return DAL.loginCheck_DAL(a,b);
        }

        public void clearBOX_BLL(MaterialSingleLineTextField a, MaterialSingleLineTextField b)
        {
            DAL.clearBOX_DAL(a,b);
        }

        public bool newRegis_BLL(MaterialSingleLineTextField a, MaterialSingleLineTextField b)
        {
            return DAL.newRegister_DAL(a,b);
        }
    }
}
