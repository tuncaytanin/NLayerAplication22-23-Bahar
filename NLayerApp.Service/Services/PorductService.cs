using NLayerApp.Core.Models;
using NLayerApp.Core.Repositories;
using NLayerApp.Core.Services;
using NLayerApp.Core.UnitOfWorks;

namespace NLayerApp.Service.Services
{
    public class PorductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public PorductService(IGenericRepository<Product> genericRepository, IUnitOfWork unitOfWork, IProductRepository productRepository) : base(genericRepository, unitOfWork)
        {
            _productRepository = productRepository;
        }
    }
}
