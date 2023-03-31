using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.DTOs
{
    public class BaseUpdateDto
    {
        public int Id { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
