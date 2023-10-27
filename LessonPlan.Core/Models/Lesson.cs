namespace LessonPlan.Core.Models
{
    public class Lesson : BaseEntity
    {
        public string LessonName { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

    }
}
