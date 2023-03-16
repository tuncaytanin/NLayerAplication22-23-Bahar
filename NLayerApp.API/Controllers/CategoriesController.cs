using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.Models;
using NLayerApp.Core.Services;

namespace NLayerApp.API.Controllers
{

    public class CategoriesController : CustomBaseController
    {

        #region DI
        private readonly ICategoryService _categoryService;
        #endregion

        // Dependecy injection => 
        public CategoriesController(ICategoryService categoryService)
        {
            //Parametreli Constrcutor -> Yapıcı Metod.
            _categoryService = categoryService;


        }
        // http://domainName/api/Categories/GetList
        /*
          HttpGet -> Header(Sadece başlık vardır. Body yok yoktur)
          HttpPost ->  Header hemde Body ->  Ekleme işlemi için kullanılır
          HttpPut => Header hemde Body => Güncelleme için
          
         */
        [Route("[action]")]
        [HttpGet]  // ÇAğırılma Yöntemi
        public async Task<List<Category>> GetList()
        {
            var sonuc = await _categoryService.GetAllAsync();
            return sonuc;
        }

        [Route("[action]")]
        [HttpPost]  // ÇAğırılma Yöntemi
        public async Task AddCategory(Category category)
        {

             await _categoryService.AddAsync(category); 

        }

        [Route("[action]")]
        [HttpPost]  // ÇAğırılma Yöntemi
        public async Task UpdateCategory(Category category)
        {
             _categoryService.Update(category);

        }
    }
}
