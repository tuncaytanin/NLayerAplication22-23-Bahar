using Microsoft.AspNetCore.Mvc;
using NLayerApp.Web.Services;

namespace NLayerApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryApiService _categoryApiService;

        public CategoryController(CategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }
        public async Task<IActionResult> Index()
        {
           var categories = await _categoryApiService.GetAllAsync();
            return View(categories);    
        }
    }
}
