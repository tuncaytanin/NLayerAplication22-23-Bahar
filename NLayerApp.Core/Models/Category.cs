﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.Models
{
    public class Category : BaseEntity , IEntity
    {
        public string Name { get; set; } 
        
        public string Description { get; set; }

        public bool IsDeleted { get; set; } 

        public virtual ICollection<Product> Products { get;}
    }
}
