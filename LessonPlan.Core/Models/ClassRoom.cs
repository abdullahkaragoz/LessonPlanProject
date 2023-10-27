namespace LessonPlan.Core.Models
{
    public class ClassRoom : BaseEntity
    {
        public string ClassRoomName { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
