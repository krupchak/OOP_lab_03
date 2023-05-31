using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [StringLength(10)]
        [RegularExpression(@"^[\x20-\x7E]+$")]
        public string PhoneNumber { get; set; }

        public bool RegisteredOn { get; set; }

        public DateTime Birthday { get; set; }

        public ICollection<StudentCourse> Students { get; set; }
    }
}
