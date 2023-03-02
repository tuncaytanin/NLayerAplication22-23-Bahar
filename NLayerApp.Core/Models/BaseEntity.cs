﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; } 

        public DateTime CreateDate { get; set; }

        // ? nullable aktif...
        public DateTime? UpdateDate { get; set; }
    }
}
