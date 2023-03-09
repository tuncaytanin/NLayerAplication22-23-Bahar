using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NLayerApp.Core.Models;
using NLayerApp.Dal.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Dal
{
    public class AppDbContext:DbContext
    {
        // ikinci hafta yapılanlar
        public AppDbContext()
        {
            // todo appDbContext parametric olarak DbContext geçerek db connection sağlayacağız
        }



        // Veritabanı yansıtılmasını istediğiniz nesneleri DbSet<Entity> şeklinde tanımlamalıyız
        public DbSet<Category> Categories { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Todo Configuration read
            optionsBuilder.UseSqlServer("Data Source=TANINPC;Initial Catalog=DbETrade22-23-Bahar;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
