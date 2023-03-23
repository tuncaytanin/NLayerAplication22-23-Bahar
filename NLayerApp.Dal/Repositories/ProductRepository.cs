using NLayerApp.Core.Models;
using NLayerApp.Core.Repositories;

namespace NLayerApp.Dal.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context):base(context) 
        {

        }
    }
}
