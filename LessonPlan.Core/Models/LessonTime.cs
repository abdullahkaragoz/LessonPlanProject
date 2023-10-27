namespace LessonPlan.Core.Models
{
    public class LessonTime : BaseEntity
    {
        public DateTime Time { get; set; }


        public ICollection<Teacher> Teachers { get; set; }
    }
}
