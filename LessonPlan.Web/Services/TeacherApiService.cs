using LessonPlan.Core.Dtos;

namespace LessonPlan.Web.Services
{
    public class TeacherApiService
    {
        private readonly HttpClient _httpClient;

        public TeacherApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TeacherDto>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<TeacherDto>>>("teachers/GetAll");

            return response.Data;
        }

        public async Task<TeacherDto> GetByIdAsync(int id)
        {

            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<TeacherDto>>($"teachers/{id}");
            return response.Data;
        }

        public async Task<TeacherDto> SaveAsync(TeacherDto newTeacher)
        {
            var response = await _httpClient.PostAsJsonAsync("teachers", newTeacher);
            if (!response.IsSuccessStatusCode) return null;
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<TeacherDto>>();

            return responseBody.Data;
        }
        public async Task<bool> UpdateAsync(TeacherDto newTeacher)
        {
            var response = await _httpClient.PutAsJsonAsync("teachers", newTeacher);

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"teachers/{id}");

            return response.IsSuccessStatusCode;
        }


    }
}
