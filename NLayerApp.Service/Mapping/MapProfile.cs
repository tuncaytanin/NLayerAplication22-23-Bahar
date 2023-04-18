using AutoMapper;
using NLayerApp.Core.DTOs.Categorie;
using NLayerApp.Core.DTOs.Products;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Service.Mapping
{
    /// <summary>
    /// NeselerArasında Maplemele yapacak
    /// Model <-> ModelDto 
    /// </summary>
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductAddDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
            CreateMap<CategoryAddDto, Category>();
            CreateMap<CategoryUpdateDto,Category>();
        }
    }
}
