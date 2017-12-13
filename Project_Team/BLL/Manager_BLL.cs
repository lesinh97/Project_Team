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
        public bool Add_GiaoVien_BLL(ChuNhiem giaoVien)
        {
            return DAL.Add_GiaoVien_DAL(giaoVien);
        }
        public bool Add_Khoa_BLL(Khoa khoaMoi)
        {
            return DAL.Add_Khoa_DAL(khoaMoi);
        }
        public bool Add_Lop_BLL(Lop lopMoi)
        {
            return DAL.Add_Lop_DAL(lopMoi);
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
        public void Edit_Diem_BLL(KetQua kq)
        {
            DAL.Update_DiemMonHoc_DAL(kq);
            DAL.TinhDTB_1Mon1SinhVien_DAL(kq.MaMonHoc,kq.MaSinhVien);

        }
        public void Edit_ThongTin_BLL(SinhVien sv)
        {
            DAL.Edit_ThongTin_DAL(sv); //Son xau trai lam
        }
        
        public string getTenLop_BLL(string malop)
        {
            return DAL.getTenLop_DAL(malop);
        }
        
        public KetQua Get_MotKetQua_BLL(string MaMonHoc, int MaSinhVien)
        {
            return DAL.Get_MotKetQua_DAL(MaMonHoc, MaSinhVien);
        }
        //get comboBox
        public List<string> Get_ListMaMonHoc_BLL(int MaSinhVien)
        {
            return DAL.Get_ListMaMonHoc_DAL(MaSinhVien);
        }
        public List<string> Get_ListMaMonHoc_BLL()
        {
            return DAL.Get_ListMaMonHoc_DAL();
        }
        public List<string> Get_ListTenMonHoc_BLL()
        {
            return DAL.Get_ListTenMonHoc_DAL();
        }
        public List<string> Get_ListQueQuan_BLL(int mssv)
        {
            return DAL.Get_ListQueQuan_DAL(mssv);
        }
        public List<string> Get_ListQueQuan_BLL()
        {
            return DAL.Get_ListQueQuan_DAL();
        }
        public List<string> Get_ListNienKhoa_BLL()
        {
            return DAL.Get_ListNienKhoa_DAL();
        }
        public List<string> Get_ListNienKhoa_BLL(int mssv)
        {
            return DAL.Get_ListNienKhoa_DAL(mssv);
        }
        public List<string> Get_ListChuNhiem_BLL()
        {
            return DAL.Get_ListChuNhiem_DAL();
        }
        public List<string> Get_ListChuNhiem_BLL(string MaKhoa)
        {
            return DAL.Get_ListChuNhiem_DAL(MaKhoa);
        }
        public List<string> Get_ListMaChuNhiem_BLL()
        {
            return DAL.Get_ListMaChuNhiem_DAL();
        }
        public List<string> Get_ListLop_BLL()
        {
            return DAL.Get_ListLop_DAL();
        }
        public List<string> Get_ListLop_BLL(int mssv)
        {
            return DAL.Get_ListLop_DAL(mssv);
        }
        public List<string> Get_ListMaLop_BLL()
        {
            return DAL.Get_ListMaLop_DAL();
        }
        public List<string> Get_ListTenKhoa_BLL()
        {
            return DAL.Get_ListTenKhoa_DAL();
        }
        public List<string> Get_ListMaKhoa_BLL()
        {
            return DAL.Get_ListMaKhoa_DAL();
        }
        //Trong code thu
        public List<object> Get_ListSV_BLL()
        {
            return DAL.Get_ListSV_DAL();
        }
        public SinhVien Get_SV_BLL(int MaSinhVien)
        {
            return DAL.Get_SV_DAL(MaSinhVien);
        }
        public List<SinhVien> Search_SV_BLL(string MaSinhVien, string TenSinhVien, string TenLop, string TenKhoa, string GVCN, string MonHoc)
        {
            return DAL.Search_SV_DAL(MaSinhVien, TenSinhVien, TenLop, TenKhoa,GVCN,MonHoc);
        }
        public bool Add_SV_BLL(SinhVien sv)
        {
            return DAL.Add_SV_DAL(sv);
        }
        public string Get_MaLop_BLL(string tenLop)
        {
            return DAL.Get_MaLop_DAL(tenLop);
        }
    }
}
