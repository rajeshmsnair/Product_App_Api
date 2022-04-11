using DeliVeggie.Price.Infrastructure.Interface;
using DeliVeggie.Price.Infrastructure.Repository;
using DeliVeggie.Price.Infrastructure.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliVeggie.Prices.Api.Extension
{
    public static class DISettings
    {
        public static void DISetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPriceService, PriceService>();
            services.AddScoped<IPriceRepository, PriceRepository>();

        }
    }
}
