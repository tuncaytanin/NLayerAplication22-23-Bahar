using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.DTOs;
using NLayerApp.Core.DTOs.Products;
using NLayerApp.Core.Models;
using NLayerApp.Core.Services;

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
        public async Task<List<Product>> GetList()
        {
            var sonuc = await _productService.GetAllAsync();
            return sonuc;
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
        public async Task<Product> GetByIdAsync(int id)
        {
            var sonuc = await _productService.GetByIdAsync(id);
            return sonuc;
        }
    }
}
