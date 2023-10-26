using AutoMapper;
using LessonPlan.Core.Dtos;
using LessonPlan.Core.Models;
using LessonPlan.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LessonPlan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ITeacherService _service;

        public TeachersController(IMapper mapper, ITeacherService teacherService) 
        {
            _mapper = mapper;
            _service = teacherService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var teachers = await _service.GetAllAsync();
            var teachersDtos = _mapper.Map<List<TeacherDto>>(teachers.ToList());

            return CreateActionResult(CustomResponseDto<List<TeacherDto>>.Success(200, teachersDtos));
        }


    }
}
