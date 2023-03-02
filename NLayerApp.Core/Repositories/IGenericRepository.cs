using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.Repositories
{

    public interface IGenericRepository<T> where T: class
    {
        Task<T> GetByIdAsync(int id); // Id ile veri geri dönüyor

        Task AddAsync(T entity); // Nesneyi ekleme yapıcak

        void Update(T entity);  // nesneyi güncellemek
        Task DeleteAsync(int id); // nesneyi id ile bulup ve daha sonra silmek için

        void Delete(T Entity); // nesneyi silmek

        IQueryable<T> GetAll(); // Veritbanında çalışacak sorguyu hazırlar.
                                // select * from category .ToList();

        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        // Veritbanında çalışacak sorguyu hazırlar.
        // select * from category where expression   -> toList();

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        // true yada false => expression kiritelrine göre

    }
}
