using Assignment1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.DBContext
{
    internal class ITIDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ; Database=EntityITI ; Trusted_Connection=True ; Encrypt=False");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses {get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> Course_Instructor { get; set; }
        public DbSet<Stud_Course> Student_Courses { get; set; }
    }
}
