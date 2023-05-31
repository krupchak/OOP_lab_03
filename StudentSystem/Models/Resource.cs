using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Resource
    {
        [Required]
        public int ResourceId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [RegularExpression(@"^[\x20-\x7E]+$")]
        public string Url { get; set; }

        public enum Type
        {
            Video,
            Presentation,
            Document,
            Other
        }

        public Type ResourceType { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
