using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.DTOs.Categories;
using NLayerApp.Core.Models;
using NLayerApp.Web.Services;

namespace NLayerApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryApiService _categoryApiService;
        private readonly IMapper _mapper;

        public CategoryController(CategoryApiService categoryApiService , IMapper mapper)
        {
            _categoryApiService = categoryApiService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
           var categories = await _categoryApiService.GetAllAsync();
            return View(categories);    
        }

        [HttpGet]
        public  IActionResult New()
        {
            var categori = new CategoryAddDto();
            return View(categori);
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            await _categoryApiService.AddAsync(categoryAddDto);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var sonuc = await _categoryApiService.DeleteAsync(id);

                return RedirectToAction("Index");

        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var categoriDto = await _categoryApiService.GetByIdAsync(id);
            return View(categoriDto);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {
            
            await _categoryApiService.UpdateAsync(_mapper.Map<CategoryUpdateDto>(categoryDto));
            return RedirectToAction("Index");
        }
    }
}
