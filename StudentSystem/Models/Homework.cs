using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Homework
    {
        [Required]
        public int HomeworkId { get; set; }

        [RegularExpression(@"^[\x20-\x7E]+$")]
        public string Content { get; set; }

        public enum Type
        {
            Application,
            Pdf,
            Zip
        }

        public Type ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}
