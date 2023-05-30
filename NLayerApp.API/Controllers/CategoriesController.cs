using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.ApiFilter.CategoryFilters;
using NLayerApp.Core.DTOs.Categorie;
using NLayerApp.Core.Models;
using NLayerApp.Core.Services;

namespace NLayerApp.API.Controllers
{

    public class CategoriesController : CustomBaseController
    {

        #region DI
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        #endregion

        // Dependecy injection => 
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            //Parametreli Constrcutor -> Yapıcı Metod.
            _categoryService = categoryService;
            _mapper = mapper;


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
            var sonuc = await _categoryService.Where(x => !x.IsDeleted).ToListAsync();
            return sonuc;
        }
        [Route("[action]")]
        [HttpGet]  // ÇAğırılma Yöntemi
        public async Task<List<Category>> GetListAll()
        {
            var sonuc = await _categoryService.GetAllAsync();
            return sonuc;
        }

        [Route("[action]")]
        [HttpPost]  // ÇAğırılma Yöntemi
        public async Task AddCategory(CategoryAddDto categoryAddDto)
        {

             await _categoryService.AddAsync(_mapper.Map<Category>(categoryAddDto)); 

        }

        [Route("[action]")]
        [HttpPut]  // ÇAğırılma Yöntemi
        public async Task UpdateCategory(CategoryUpdateDto categoryUpdateDto)
        {
             _categoryService.Update(_mapper.Map<Category>(categoryUpdateDto));

        }
        [Route("[action]")]
        [HttpGet]  // ÇAğırılma Yöntemi
        public async Task<Category> GetById(int id)
        {
            var sonuc = await _categoryService.GetByIdAsync(id);
            return sonuc;
        }

        [Route("[action]")]
        [HttpPost]  // ÇAğırılma Yöntemi
        public async Task IsDeletedCategoryById(int id)
        {

            await _categoryService.IsDeletedByIdAsync(id);
        }

        [Route("[action]")]
        [HttpPost]  // ÇAğırılma Yöntemi
        public async Task<List<Category>> GetByFilterAsync(CategoryFilter parametre)
        {
            if (parametre.IsDeleted)
            {
                var sonuc = await _categoryService.Where(x => x.Name.Contains(parametre.Name) && x.IsDeleted == parametre.IsDeleted).ToListAsync();
                return sonuc;
            }
            else
            {
                var sonuc = await _categoryService.Where(x => x.Name.Contains(parametre.Name)).ToListAsync();
                return sonuc;
            }
 
        }

    }
}
