using AutoMapper;
using LessonPlan.Core.Models;
using LessonPlan.Core.Repositories;
using LessonPlan.Core.Services;
using LessonPlan.Core.UnitOfWorks;

namespace LessonPlan.Service.Services
{
    public class TeacherService : Service<Teacher>, ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;
        public TeacherService(IGenericRepository<Teacher> repository, IUnitOfWork unitOfWork, IMapper mapper, ITeacherRepository teacherRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _teacherRepository = teacherRepository;
        }


    }
}
