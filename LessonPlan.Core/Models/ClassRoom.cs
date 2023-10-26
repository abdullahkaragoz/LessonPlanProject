namespace LessonPlan.Core.Models
{
    public class ClassRoom 
    {
        public int Id { get; set; }
        public string ClassRoomName { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
