using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Models;

namespace NLayerApp.Dal.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id =1,Code="0001",CreateDate =DateTime.Now,Name = "Tost Makinası", CategoryId =1,Price=1500,Stock=15 },
                new Product { Id = 2, Code = "00002", CreateDate = DateTime.Now, Name = "Leptop Çantası", CategoryId = 2, Price = 750, Stock = 20 }
                );
        }
    }
}
