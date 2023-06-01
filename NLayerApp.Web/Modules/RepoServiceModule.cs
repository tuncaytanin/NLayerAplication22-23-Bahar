using NLayerApp.Core.Repositories;
using NLayerApp.Core.Services;
using NLayerApp.Core.UnitOfWorks;
using NLayerApp.Dal.Repositories;
using NLayerApp.Dal.UnitOfWorks;
using NLayerApp.Dal;
using System.Reflection;
using Module = Autofac.Module;
using Autofac;
using NLayerApp.Service.Services;

namespace NLayerApp.Web.Modules
{
    public class RepoServiceModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            /*
             builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<ICateogryRepository, CategoryRepository>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
             */
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var dalAssemply = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssemply = Assembly.GetAssembly(typeof(CategoryService));
            var apiAssemply = Assembly.GetExecutingAssembly();

            // Dinamik DI oluşturma...

            builder.RegisterAssemblyTypes(dalAssemply, serviceAssemply, apiAssemply).Where(x => x.Name.EndsWith("Repository") || x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

        }
    }
}
