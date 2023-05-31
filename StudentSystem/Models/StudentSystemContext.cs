using System.Collections.Generic;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;

namespace StudentSystem.Models
{
    internal class StudentSystemContext : DbContext
    {
        public StudentSystemContext(DbContextOptions<StudentSystemContext> options)
        : base(options)
        {
        }

        internal DbSet<Course> Cources { get; set; }
        internal DbSet<Homework> HomeworkSubmissions { get; set; }
        internal DbSet<Resource> Resources { get; set; }
        internal DbSet<StudentCourse> StudentCourses { get; set; }
        internal DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 1, Name = "Nastya", PhoneNumber = "0964567076", RegisteredOn = true });
            modelBuilder.Entity<Course>().HasData(new Course { CourseId = 1, Name = "OOP", Description = "-----", StartDate = DateTime.Now, EndDate = DateTime.Today, Price = 50 });
            modelBuilder.Entity<Resource>().HasData(new Resource { ResourceId = 1, CourseId = 1, Name = "yt", ResourceType = Models.Resource.Type.Video, Url = "C:\\Навчання\\2_курс\\2_семестр\\ООП\\OOP_lab_03\\StudentSystem" });
            modelBuilder.Entity<Homework>().HasData(new Homework { HomeworkId = 1, Content = "grtsh", ContentType = Models.Homework.Type.Pdf, SubmissionTime = DateTime.Today, CourseId = 1, StudentId = 1 });
        }
    }
}
