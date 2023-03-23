using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Dal.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name ="Elektronik Eşyalar",Description ="Elektornik Eşyalar",CreateDate = DateTime.Now },
                new Category { Id = 2, Name = "Çantalar"  , Description="Çantalar" ,CreateDate=DateTime.Now },
                new Category { Id = 3, Name = "Telefonlar", Description="Telefonlar", CreateDate = DateTime.Now }
                );
        }
    }
}
