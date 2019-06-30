using Microsoft.EntityFrameworkCore;
using tCoreAPI.Data.enums;
using tCoreAPI.Data.models;

namespace tCoreAPI.Data.content
{
    public class TDataContext : DbContext
    {
        public TDataContext(DbContextOptions options): base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Shema
            modelBuilder.HasDefaultSchema("TheDefaultShema");

            modelBuilder.Entity<Employee>().ToTable("TableName", "AnotherShema");

            // Precision
            modelBuilder.Entity<Employee>().Property(emp => emp.Salary).HasColumnType("decimal(5, 2)"); //precision of 5 and scale of 2.


            // Many To Many
            // see models\ManyToManyExample first
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });


            // Initial value ( data seeding )
            modelBuilder.Entity<Employee>().HasData(

                new Employee
                {
                    Id = 1,
                    EmployeeGender = Gender.Male,
                    Notes = "some notes",
                    EmployeeName = "Emp1",
                    Salary = 233,
                    YearsOfExp = 3
                },

                new Employee
                {
                    Id = 2,
                    EmployeeGender = Gender.Male,
                    Notes = "some notes",
                    EmployeeName = "Emp2",
                    Salary = 123,
                    YearsOfExp = 1
                },

                new Employee
                {
                    Id = 3,
                    EmployeeGender = Gender.Female,
                    Notes = "some notes",
                    EmployeeName = "Emp3",
                    Salary = 2134,
                    YearsOfExp = 11
                },

                new Employee
                {
                    Id = 4,
                    EmployeeGender = Gender.Female,
                    Notes = "some notes",
                    EmployeeName = "Emp4",
                    Salary = 0,
                    YearsOfExp = 0
                }
            );
        }


        // Many To Many 
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }



        public DbSet<Employee> Employees { get; set; }



    }
}
