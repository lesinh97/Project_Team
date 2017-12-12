namespace DBTest
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;

    public class Manager : DbContext
    {
        // Your context has been configured to use a 'Manager' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DBTest.Manager' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Manager' 
        // connection string in the application configuration file.
        public Manager()
            : base("name=Manager")
        {
            Database.SetInitializer<Manager>(new DataIntializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<ChuNhiem> ChuNhiems { get; set; }
    }

    public class DataIntializer: DropCreateDatabaseAlways<Manager>
    {
        protected override void Seed(Manager context)
        {
            context.Khoas.Add(new Khoa { Id = "K01", Name = "Khoa1" });
            context.GiaoViens.Add(new GiaoVien { Id = "G01", Name = "gv1", IdKhoa = "K01" });
            context.Lops.Add(new Lop { Id = "L01", Name = "lop1", IdKhoa = "K01" });
            context.ChuNhiems.Add(new ChuNhiem { IdGV = "G01", IdLop = "L01" });
            context.SaveChanges();
        }
    }

    public class Khoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Lop> Lops { get; set; }
        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
    }

    public class GiaoVien
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string IdKhoa { get; set; }
        [ForeignKey("IdKhoa")]
        public virtual Khoa Khoa { get; set; }
    }

    public class Lop
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string IdKhoa { get; set; }
        [ForeignKey("IdKhoa")]
        public virtual Khoa Khoa { get; set; }
    }
    public class ChuNhiem
    {
        [Key, Column(Order = 0)]
        public string IdLop { get; set; }
        [ForeignKey("IdLop")]
        public virtual Lop Lop { get; set; }

        [Key, Column(Order = 1)]
        public string IdGV { get; set; }
        [ForeignKey("IdGV")]
        public virtual GiaoVien GiaoVien { get; set; }
    }
}