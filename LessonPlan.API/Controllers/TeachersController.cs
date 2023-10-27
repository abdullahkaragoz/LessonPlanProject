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

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var teachers = await _service.GetAllAsync();
            var teachersDtos = _mapper.Map<List<TeacherDto>>(teachers.ToList());

            return CreateActionResult(CustomResponseDto<List<TeacherDto>>.Success(200, teachersDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var teacher = await _service.GetByIdAsync(id);
            var teachersDto = _mapper.Map<TeacherDto>(teacher);
            return CreateActionResult(CustomResponseDto<TeacherDto>.Success(200, teachersDto));
        }


        [HttpPost]
        public async Task<IActionResult> Save(TeacherDto productDto)
        {
            var teacher = await _service.AddAsync(_mapper.Map<Teacher>(productDto));
            var productsDto = _mapper.Map<TeacherDto>(teacher);
            return CreateActionResult(CustomResponseDto<TeacherDto>.Success(201, productsDto));
        }


        [HttpPut]
        public async Task<IActionResult> Update(TeacherUpdateDto productDto)
        {
            await _service.UpdateAsync(_mapper.Map<Teacher>(productDto));

            return CreateActionResult(CustomResponseDto<TeacherDto>.Success(204));
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var teacher = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(teacher);

            return CreateActionResult(CustomResponseDto<TeacherDto>.Success(204));
        }

    }
}
