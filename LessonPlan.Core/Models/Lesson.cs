namespace LessonPlan.Core.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string LessonName { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

    }
}
