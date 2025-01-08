using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Helpers;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(connectionString)); //, sqlServerOption => sqlServerOption.EnableRetryOnFailure()

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ProductService>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
