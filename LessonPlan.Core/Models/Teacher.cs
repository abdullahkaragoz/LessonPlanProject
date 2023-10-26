using System.Text.Json.Serialization;

namespace LessonPlan.Core.Models
{
    public class Teacher 
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }

        public int ClassRoomId { get; set; }
        public int LessonId { get; set; }
        public int LessonTimeId { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public Lesson Lesson { get; set; }
        public LessonTime LessonTime { get; set; }

    }
}
