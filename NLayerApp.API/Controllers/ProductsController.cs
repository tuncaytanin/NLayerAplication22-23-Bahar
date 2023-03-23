using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.Models;
using NLayerApp.Core.Services;

namespace NLayerApp.API.Controllers
{

    public class ProductsController : CustomBaseController
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
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
        public async Task AddCategory(Product product)
        {

            await _productService.AddAsync(product);

        }

        [Route("[action]")]
        [HttpPost]  // ÇAğırılma Yöntemi
        public async Task UpdateCategory(Product product)
        {
            _productService.Update(product);

        }
    }
}
