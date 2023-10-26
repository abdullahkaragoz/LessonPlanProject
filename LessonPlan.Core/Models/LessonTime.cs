namespace LessonPlan.Core.Models
{
    public class LessonTime
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }


        public ICollection<Teacher> Teachers { get; set; }
    }
}
