using System.Text.Json.Serialization;

namespace LessonPlan.Core.Models
{
    public class LessonPlan : BaseEntity
    {
        public string PlanSummary { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
