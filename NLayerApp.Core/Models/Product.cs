using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.Models
{
    public class Product : BaseEntity , IEntity
    {
        public string Name { get; set; }

        public int Stock { get; set; }

        public string Code { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        //public bool IsDeleted { get; set; }

        public virtual Category Category { get; set; }

        // todo  procut comment count, product like count , product score
    }
}
