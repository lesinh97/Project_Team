using System.Diagnostics;

namespace Project_Team
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Manager : DbContext
    {
        // Your context has been configured to use a 'Manager' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Project_Team.Manager' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Manager' 
        // connection string in the application configuration file.
        public Manager()
            : base("name=Manager")
        {
            Database.SetInitializer<Manager>(new Initializer());
        }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<ChuNhiem> ChuNhiems { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<KetQua> KetQuas { get; set; }
        public virtual DbSet<Users> Userses { get; set; }

        public class Initializer : DropCreateDatabaseIfModelChanges<Manager>
        {
            protected override void Seed(Manager context)
            {
                context.Khoas.Add(new Khoa {MaKhoa = "CNTT", TenKhoa = "Công nghệ thông tin"});
                context.ChuNhiems.Add(new ChuNhiem {MaGiaoVien = "CNTT_GV_1", TenGiaoVien = "Bùi Hiển"});
                context.Lops.Add(new Lop {MaLop = "CNTT1", TenLop = "15TCLC2", MaKhoa = "CNTT", MaGiaoVien = "CNTT_GV_1"});
                context.MonHocs.Add(new MonHoc {MaMonHoc = "MH001", TenMonHoc = "BOT Cai Lậy", TinChi = 30});
                context.MonHocs.Add(new MonHoc { MaMonHoc = "MH002", TenMonHoc = "BOT Cai Lậy", TinChi = 30 });
                context.SinhViens.Add(new SinhVien {MaSinhVien = 1, TenSinhVien = "Cai Lậy", GioiTinh = true, QueQuan = "Quảng Nam", NgaySinh = DateTime.Parse("1996-06-05"),MaLop = "CNTT1", NienKhoa = 2015, TotNghiep = false});
                context.SinhViens.Add(new SinhVien { MaSinhVien = 2, TenSinhVien = "Cai Lậy", GioiTinh = true, QueQuan = "Quảng Nam", NgaySinh = DateTime.Parse("1996-06-05"), MaLop = "CNTT1", NienKhoa = 2015, TotNghiep = false });
                context.SinhViens.Add(new SinhVien { MaSinhVien = 3, TenSinhVien = "Cai Lậy", GioiTinh = true, QueQuan = "Quảng Nam", NgaySinh = DateTime.Parse("1996-06-05"), MaLop = "CNTT1", NienKhoa = 2015, TotNghiep = false });
                context.KetQuas.Add(new KetQua { MaSinhVien = 1, MaMonHoc = "MH001", DiemBaiTap = 6.9, DiemGiuaKi = 5.6, DiemCuoiKi = 7.2 });
                context.KetQuas.Add(new KetQua { MaSinhVien = 1, MaMonHoc = "MH002", DiemBaiTap = 5, DiemGiuaKi = 4, DiemCuoiKi = 3 });
                context.KetQuas.Add(new KetQua { MaSinhVien = 2, MaMonHoc = "MH001", DiemBaiTap = 8, DiemGiuaKi = 9, DiemCuoiKi = 10 });
                context.KetQuas.Add(new KetQua { MaSinhVien = 2, MaMonHoc = "MH002", DiemBaiTap = 8, DiemGiuaKi = 7, DiemCuoiKi = 6 });
                context.KetQuas.Add(new KetQua { MaSinhVien = 3, MaMonHoc = "MH001", DiemBaiTap = 5, DiemGiuaKi = 5.5, DiemCuoiKi = 6.5 });
                context.KetQuas.Add(new KetQua { MaSinhVien = 3, MaMonHoc = "MH002", DiemBaiTap = 6.9, DiemGiuaKi = 5.6, DiemCuoiKi = 7.2 });
                context.Userses.Add(new Users {ID = 1, Pass = "abc123"});
                context.SaveChanges();

            }
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}