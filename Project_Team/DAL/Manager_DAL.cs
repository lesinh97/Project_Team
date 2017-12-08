using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

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
            if (s.Any())
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

        public bool Add_Khoa_DAL(Khoa khoaMoi)
        {
            var s = db.Khoas.Where(p => p.MaKhoa == khoaMoi.MaKhoa).Select(p => p);
            if (s.Any())
            {
                MessageBox.Show("Đã có khoa này");
                return false;
            }
            else
            {
                db.Khoas.Add(khoaMoi);
                db.SaveChanges();
                return true;
            }

        }

        public bool Add_ChuNhiem_DAL(ChuNhiem cnhiem)
        {
            var s = db.ChuNhiems.Where(p => p.MaGiaoVien == cnhiem.MaGiaoVien).Select(p => p);
            if (s.Any())
            {
                MessageBox.Show("Đã có giáo viên này");
                return false;
            }
            else
            {
                db.ChuNhiems.Add(cnhiem);
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

        public bool loginCheck_DAL(MaterialSingleLineTextField a, MaterialSingleLineTextField b)
        {
            int id = Int32.Parse(a.Text);
            string pass = b.Text;
            if (DangNhap_DAL(id, pass))
            {
                MainForm mf = new MainForm();
                mf.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                clearBOX_DAL(a, b);
                return false;
            }
        }

        public void clearBOX_DAL(MaterialSingleLineTextField a, MaterialSingleLineTextField b)
        {
            a.Clear();
            b.Clear();
        }

        public bool newRegister_DAL(MaterialSingleLineTextField a, MaterialSingleLineTextField b)
        {
            Users us = new Users();
            us.ID = Int32.Parse(a.Text);
            us.Pass = b.Text;
            if (Add_User_DAL(us))
            {
                MessageBox.Show("Thêm thành công người dùng mới");
                return true;
            }
            else
            {
                clearBOX_DAL(a, b);
                return false;
            }
        }


        // Bắt đầu phần code chứng năng tính điểm trung bình
        // Sở hữu Bùi Sơn

        private string TinhDiemChu(double DiemThang10)
        {
            if (DiemThang10 >= 0 && DiemThang10 < 4) return "F";
            else if (DiemThang10 >= 4 && DiemThang10 < 5.5) return "D";
            else if (DiemThang10 >= 5.5 && DiemThang10 < 7) return "C";
            else if (DiemThang10 >= 7 && DiemThang10 < 8.5) return "B";
            else return "A";
        }

        private double TinhDiem4(double DiemThang10)
        {
            if (DiemThang10 >= 0 && DiemThang10 < 4) return 0;
            else if (DiemThang10 >= 4 && DiemThang10 < 5.5) return 1;
            else if (DiemThang10 >= 5.5 && DiemThang10 < 7) return 2;
            else if (DiemThang10 >= 7 && DiemThang10 < 8.5) return 3;
            else return 4;
        }

        public void TinhDTB_1Mon1SinhVien_DAL(string MaMonHoc, int MaSinhVien)
        {
            KetQua s = db.KetQuas.Single(p => p.MaMonHoc.Equals(MaMonHoc.Trim()) && p.MaSinhVien == MaSinhVien);
            s.DiemTrungBinh = s.DiemBaiTap * 0.2 + s.DiemGiuaKi * 0.2 + s.DiemCuoiKi * 0.6;
            s.DiemChu = TinhDiemChu(s.DiemTrungBinh);
            db.SaveChanges();
        }

        public void TinhDTB_MotMon_DAL(string MaMonHoc)
        {
            List<KetQua> s = db.KetQuas.Where(p => p.MaMonHoc == MaMonHoc).Select(p => p).ToList<KetQua>();
            foreach (KetQua item in s)
            {
                TinhDTB_1Mon1SinhVien_DAL(MaMonHoc, item.MaSinhVien);
            }
        }

        public void TinhDTB_TatCacMon_DAL()
        {
            List<MonHoc> s = db.MonHocs.Select(p => p).ToList<MonHoc>();
            foreach (var item in s)
            {
                TinhDTB_MotMon_DAL(item.MaMonHoc);
            }
        }

        public void TinhDTL_MotSinhVien_DAL(int MaSinhVien)
        {
            double diemTichLuy = 0;
            int tongTinChi = 0;
            var s = db.KetQuas.Where(p => p.MaSinhVien == MaSinhVien).Join(db.MonHocs, p => p.MaMonHoc, k => k.MaMonHoc,
                (p, k) => new
                {
                    p.MaSinhVien,
                    p.MaMonHoc,
                    p.DiemTrungBinh,
                    k.TinChi
                }).ToList();
            foreach (var item in s)
            {
                diemTichLuy = diemTichLuy + TinhDiem4(item.DiemTrungBinh) * item.TinChi;
                tongTinChi += item.TinChi;
            }
            SinhVien sinhVien = db.SinhViens.Single(p => p.MaSinhVien == MaSinhVien);
            sinhVien.DiemTrungBinh = diemTichLuy / tongTinChi;
            db.SaveChanges();
        }

        private double DiemThang4(string DiemChu)
        {
            if (DiemChu == "A") return 4;
            else if (DiemChu == "B") return 3;
            else if (DiemChu == "C") return 2;
            else if (DiemChu == "D") return 1;
            else return 0;
        }


        // Kết thúc phần code chứng năng tính điểm trung bình
        // Sở hữu Bùi Sơn



        public string getTenLop_DAL(string maLop)
        {
            var s = db.Lops.Where(p => p.MaLop == maLop).Single();
            string tenLop = s.TenLop;
            return tenLop;
        }

        ///////////////////////////////////////////////////////
        public KetQua Get_MotKetQua(string MaMonHoc, int MaSinhVien)
        {
            return db.KetQuas.Single(p => p.MaMonHoc == MaMonHoc.Trim() && p.MaSinhVien == MaSinhVien);
        }

        public void Update_DiemMonHoc(KetQua ketQua)
        {
            KetQua kq = Get_MotKetQua(ketQua.MaMonHoc, ketQua.MaSinhVien);
            kq.DiemBaiTap = ketQua.DiemBaiTap;
            kq.DiemGiuaKi = ketQua.DiemGiuaKi;
            kq.DiemCuoiKi = ketQua.DiemCuoiKi;
            db.SaveChanges();
        }

        // Các hàm get comboBox
        public List<string> Get_ListMaMonHoc_DAL(int mssv)
        {
            List<string> list = new List<string>();
            var s = db.KetQuas.Where(p => p.MaSinhVien == mssv).Select(p => p.MonHoc.TenMonHoc).Distinct();
            foreach (var i in s)
            {
                list.Add(i.Trim());
            }
            return list;
        }
        public List<string> Get_ListMaMonHoc_DAL()
        {
            List<string> list = new List<string>();
            var s = db.KetQuas.Select(p => p.MaMonHoc).ToList();
            foreach (var i in s)
            {
                list.Add(i.Trim());
            }
            return list;
        }
        public List<string> Get_ListQueQuan_DAL(int mssv)
        {
            List<string> list = new List<string>();
            var s = db.SinhViens.Where(p=>p.MaSinhVien == mssv).Select(p => p.QueQuan).ToList();
            foreach (var i in s)
            {
                list.Add(i.Trim());
            }
            return list;
        }
        public List<string> Get_QueQuan_DAL()
        {
            List<string> list = new List<string>();
            var s = db.SinhViens.Select(p => p.QueQuan).Distinct().ToList();
            foreach (var i in s)
            {
                list.Add(i.Trim());
            }
            return list;
        }
        public List<int> Get_ListNienKhoa_DAL()
        {
            List<int> list = new List<int>();
            var s = db.SinhViens.Select(p => p.NienKhoa).Distinct().ToList();
            foreach (var i in s)
            {
                list.Add(i);
            }
            return list;
        }
        public List<int> Get_ListNienKhoa_DAL(int mssv)
        {
            List<int> list = new List<int>();
            var s = db.SinhViens.Where(p=>p.MaSinhVien == mssv).Select(p => p.NienKhoa).ToList();
            foreach (var i in s)
            {
                list.Add(i);
            }
            return list;
        }
        public List<string> Get_ListChuNhiem_DAL()
        {
            List<string> list= new List<string>();
            var s = db.ChuNhiems.Select(p => p.TenGiaoVien).ToList();
            foreach (var i in s)
            {
                list.Add(i.Trim());
            }
            return list;
        }
        public List<string> Get_ListChuNhiem_DAL(string MaKhoa)
        {
            List<string> list = new List<string>();
            var s = db.ChuNhiems.Where(p => p.MaKhoa == MaKhoa).Select(p => p.TenGiaoVien).ToList();
            foreach (var i in s)
            {
                list.Add(i.Trim());
            }
            return list;
        }
        public List<string> Get_ListLop_DAL()
        {
            List<string> list = new List<string>();
            var s = db.Lops.Select(p => p.TenLop).Distinct().ToList();
            foreach (var iLop in s)
            {
                list.Add(iLop);
            }
            return list;
        }

        public List<string> Get_ListLop_DAL(int mssv)
        {
            List<string> list = new List<string>();
            var s = db.SinhViens.Where(p => p.MaSinhVien == mssv)
                .Join(db.Lops, p => p.MaLop, k => k.MaLop, (p, k) => new {k.TenLop}).Select(k=>k.TenLop);
            foreach (var iLop in s)
            {
                list.Add(iLop);
            }
            return list;
        }
        
    }
}