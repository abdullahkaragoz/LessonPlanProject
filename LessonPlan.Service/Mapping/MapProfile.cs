using AutoMapper;
using LessonPlan.Core.Dtos;
using LessonPlan.Core.Models;

namespace LessonPlan.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Teacher, TeacherDto>().ReverseMap();
            CreateMap<ClassRoom, ClassRoom>().ReverseMap();
            CreateMap<Lesson, LessonDto>().ReverseMap();
            CreateMap<LessonPlan.Core.Models.LessonPlan, LessonPlanDto>();

        }

    }
}
