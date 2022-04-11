using DeliVeggie.Products.Domain;
using DeliVeggie.Products.Domain.Interfaces;
using DeliVeggie.Products.Infrastructure.Data.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliVeggie.Product.Api.Extensions
{
    public static class DISetting
    {
        public static void DISetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
