using ClothingStore.Application.Interfaces;
using ClothingStore.Persistance.EntityFrameworks;
using ClothingStore.Persistance.EntityFrameworks.Repositories;
using ClothingStore.Persistance.Interceptors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("local");

            services
               .AddDbContext<ClothingStoreContext>(options => options
               .UseSqlServer(connectionString)
               .AddInterceptors(new UpdateBaseEntityInterceptor()));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

    }
}
