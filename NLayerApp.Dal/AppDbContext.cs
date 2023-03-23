using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NLayerApp.Core.Models;
using NLayerApp.Dal.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Dal
{
    public class AppDbContext:DbContext
    {
        // ikinci hafta yapılanlar
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            // todo appDbContext parametric olarak DbContext geçerek db connection sağlayacağız
        }


        // Veritabanı yansıtılmasını istediğiniz nesneleri DbSet<Entity> şeklinde tanımlamalıyız
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }


    }
}
