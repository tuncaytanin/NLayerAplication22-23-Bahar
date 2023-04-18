using NLayerApp.Core.Models;
using NLayerApp.Core.Repositories;
using NLayerApp.Core.Services;
using NLayerApp.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Service.Services
{
    public class CategoryService : Service<Category>,ICategoryService
    {
        private readonly ICateogryRepository _cateogryRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(IGenericRepository<Category> genericRepository, IUnitOfWork unitOfWork, ICateogryRepository cateogryRepository):base(genericRepository, unitOfWork)
        {
            _cateogryRepository = cateogryRepository;
            _unitOfWork= unitOfWork;
        }

        public async Task IsDeletedByIdAsync(int id)
        {
            var category= await _cateogryRepository.GetByIdAsync(id);
            category.IsDeleted = true;

            _cateogryRepository.Update(category);
            _unitOfWork.Commit();
        }
    }
}
