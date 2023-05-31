using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using NLayerApp.Core.ApiFilter;
using NLayerApp.Core.DTOs;
using NLayerApp.Core.DTOs.Categories;
using NLayerApp.Core.DTOs.Products;
using NLayerApp.Core.Models;
using NLayerApp.Core.Services;
using NLayerApp.Service.Services;

namespace NLayerApp.API.Controllers
{

    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        public ProductsController(IProductService productService , IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [Route("[action]")]
        [HttpGet]  // ÇAğırılma Yöntemi
        public async Task<List<ProductDto>> GetList()
        {
            var sonuc = await _productService.GetAllAsync();
            return _mapper.Map<List<ProductDto>>(sonuc);
        }
        [Route("[action]")]
        [HttpPost]  // ÇAğırılma Yöntemi
        public async Task<List<ProductDto>> GetByFilter(ProductFilter parametre)
        {
            List<Product> sonuc;
            if (!string.IsNullOrEmpty(parametre.Name))
                sonuc = await _productService.Where(x => x.Name.Contains(parametre.Name)).ToListAsync();
            else
                 sonuc = await _productService.GetAllAsync();

            return _mapper.Map<List<ProductDto>>(sonuc);
        }

        [Route("[action]")]
        [HttpPost]  // ÇAğırılma Yöntemi
        public async Task AddProduct(ProductAddDto productDto)
        {


           var product = _mapper.Map<Product>(productDto);
            await _productService.AddAsync(product);

        }

        [Route("[action]")]
        [HttpPost]  // ÇAğırılma Yöntemi
        public async Task UpdateProduct(ProductUpdateDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _productService.Update(product);

        }
        [Route("[action]")]
        [HttpGet]  // ÇAğırılma Yöntemi
        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var sonuc = await _productService.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(sonuc);
        }
        [Route("[action]")]
        [HttpPost]  // ÇAğırılma Yöntemi
        public async Task Delete(int id)
        {
            await _productService.DeleteAsync(id);
        }
    }
}
