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
        public virtual DbSet<Alumnus> sv { get; set; }
        public virtual DbSet<Classes> cl { get; set; }
        public virtual DbSet<Lecture> mh { get; set; }
        public virtual DbSet<Lecturers> gv { get; set; }
        public virtual DbSet<Major> khoa { get; set; }
        public virtual DbSet<Users> user { get; set; }

        public class Initializer : CreateDatabaseIfNotExists<Manager>
        {
            protected override void Seed(Manager context)
            {
                context.khoa.Add(new Major { Major_ID = 1, Major_name = "CNTT" });
                context.khoa.Add(new Major { Major_ID = 1, Major_name = "Chemical" });
                context.cl.Add(new Classes { Class_ID = 1, Class_name = "15TCLC2", Major_ID = 1 });
                context.cl.Add(new Classes { Class_ID = 2, Class_name = "15SHH", Major_ID = 2 });
                context.gv.Add(new Lecturers { Lecturers_ID = 1, Lecturer_name = "ABC", Major_ID = 1 });
                context.gv.Add(new Lecturers { Lecturers_ID = 2, Lecturer_name = "XYZ", Major_ID = 2 });
                context.sv.Add(new Alumnus
                {
                    Student_ID = 1,
                    Name = "A",
                    Birthday = DateTime.Parse("05-06-1996"),
                    Gender = false,
                    Hometown = "Danang",
                    Class_ID = 2,
                    Year_Grad = "2020"
                });
                context.mh.Add(new Lecture
                {
                    Lecture_ID = 1,
                    Lecturers_ID = 1,
                    Credits = 2,
                    Lecture_name = "C",
                    Student_ID = 1,
                    Avg_mark = 2,
                    End_mark = 4,
                    Exe_mark = 6,
                    Mid_mark = 6
                });
                context.user.Add(new Users { ID = 1235, Pass = "abc" });
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