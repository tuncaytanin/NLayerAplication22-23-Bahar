using NLayerApp.Core.Models;

namespace NLayerApp.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        Task IsDeletedByIdAsync(int id); // nesneyi id ile bulup ve daha sonra silmek için
    }
}
