using NLayerApp.Core.DTOs.Categories;
using NLayerApp.Core.DTOs.Responses;
using NLayerApp.Core.Models;

namespace NLayerApp.Web.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpClient;
        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient= httpClient;
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<CategoryDto>>("GetListAll");

            return response;
        }

        public async Task AddAsync(CategoryAddDto categoryAddDto)
        {
            var response = await _httpClient.PostAsJsonAsync<CategoryAddDto>("AddCategory",categoryAddDto);

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response=  await _httpClient.DeleteAsync($"IsDeletedCategoryById/{id}");
            return response.IsSuccessStatusCode;

        }

        public async Task<CategoryDto> GetByIdAsync(int id)
        {
            var sonuc = await _httpClient.GetFromJsonAsync<CategoryDto>($"GetById/{id}");


            return sonuc;
        }

        public async Task UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
           await _httpClient.PutAsJsonAsync<CategoryUpdateDto>("UpdateCategory", categoryUpdateDto);

        }
    }
}
