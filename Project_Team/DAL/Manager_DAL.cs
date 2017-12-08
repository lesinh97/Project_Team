﻿using System;
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
                clearBOX_DAL(a,b);
                return false;
            }
        }

        public string getTenLop_DAL(string maLop)
        {
            var s = db.Lops.Where(p => p.MaLop == maLop).Single();
            string tenLop = s.TenLop;
            return tenLop;
        }
        ///////////////////////////////////////////////////////
        
        // Hàm get từ mã sinh viên ra edit của Sinh
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

        public List<int> getNienKhoa_CBB_DAL()
        {
            List<int> list = new List<int>();
            var s = db.SinhViens.Select(p => p.NienKhoa).Distinct().ToList();
            foreach (var i in s)
            {
                list.Add(i);
            }
            return list;
        }
        }
    }

