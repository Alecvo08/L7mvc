
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{

    //tinfo200:[2021-03-13-alecv-dykstra1] - School Context class features an entity framework that uses property names
    //tinfo200:[2021-03-13-alecv-dykstra1] - Those property names must be the same as the DbSet names that are set
    //tinfo200:[2021-03-13-alecv-dykstra1] - Once everything is completed it creates tables with the names in the code
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}