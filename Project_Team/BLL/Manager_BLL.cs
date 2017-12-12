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
        public bool Add_Khoa_BLL(Khoa khoaMoi)
        {
            return DAL.Add_Khoa_DAL(khoaMoi);
        }
        public bool Add_ChuNhiem_BLL(ChuNhiem cnhiem)
        {
            return DAL.Add_ChuNhiem_DAL(cnhiem);
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
        public string getTenLop_BLL(string malop)
        {
            return DAL.getTenLop_DAL(malop);
        }
        ////////////////////////////////////////////////
        //songtranvan
        public void ReadExcel_BLL(string path)
        {
            DAL.ReadExcel_DAL(path);
        }
    }
}
