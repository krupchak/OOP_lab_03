namespace StudentSystem.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }

        public Course Course { get; set; }

        public Student Student { get; set; }
    }
}
