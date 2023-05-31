using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Course
    {
        [Required]
        public int CourseId { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public float Price { get; set; }

        public ICollection<StudentCourse> Courses { get; set; }
    }
}
