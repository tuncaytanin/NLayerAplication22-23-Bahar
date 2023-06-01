﻿using NLayerApp.Core.DTOs.Categories;
using NLayerApp.Core.DTOs.Responses;

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
            var response = await _httpClient.GetFromJsonAsync<List<CategoryDto>>("Categories/GetList");


            return response;
        }
    }
}