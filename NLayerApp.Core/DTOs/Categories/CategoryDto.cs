using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.DTOs.Categories
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        // ? nullable aktif...
        public DateTime? UpdateDate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

    }
}
