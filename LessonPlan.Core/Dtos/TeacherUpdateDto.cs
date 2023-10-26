using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonPlan.Core.Dtos
{
    public class TeacherUpdateDto
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }

        public int ClassRoomId { get; set; }
        public int LessonId { get; set; }
        public int LessonTimeId { get; set; }
    }
}
