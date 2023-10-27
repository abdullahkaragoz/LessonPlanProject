using LessonPlan.Core.Dtos;
using LessonPlan.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LessonPlan.Web.Controllers
{
    public class TeachersController : Controller
    {
        private readonly TeacherApiService _teacherApiService;

        public TeachersController(TeacherApiService teacherApiService)
        {
            _teacherApiService = teacherApiService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _teacherApiService.GetAllAsync());
        }

        public async Task<IActionResult> Save()
        {
            var teachersDto = await _teacherApiService.GetAllAsync();

            ViewBag.categories = new SelectList(teachersDto, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(TeacherDto teacherDto)
        {
            if (ModelState.IsValid)
            {
                await _teacherApiService.SaveAsync(teacherDto);

                return RedirectToAction(nameof(Index));
            }

            var teachersDto = await _teacherApiService.GetAllAsync();

            ViewBag.categories = new SelectList(teachersDto, "Id", "Name");

            return View();
        }

        public async Task<IActionResult> Update(int id)
        {
            var teacher = await _teacherApiService.GetByIdAsync(id);

            return View(teacher);
        }

        [HttpPost]
        public async Task<IActionResult> Update(TeacherDto teacherDto)
        {
            if (ModelState.IsValid)
            {
                await _teacherApiService.UpdateAsync(teacherDto);

                return RedirectToAction(nameof(Index));
            }

            var teachersDto = await _teacherApiService.GetAllAsync();

            ViewBag.categories = new SelectList(teachersDto, "Id", "Name", teacherDto.Id);

            return View(teacherDto);
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _teacherApiService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
