using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Models;
using NLayerApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Dal.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICateogryRepository
    {

        public CategoryRepository(AppDbContext context):base(context) 
        {

        }


    }
}
