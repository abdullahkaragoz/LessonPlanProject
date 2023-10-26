using System.Text.Json.Serialization;

namespace LessonPlan.Core.Models
{
    public class LessonPlan //NOT: Bu tabloyu tam olarak anlamadığım için boş bıraktım
    {
        public int Id { get; set; }
        public string PlanSummary { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
