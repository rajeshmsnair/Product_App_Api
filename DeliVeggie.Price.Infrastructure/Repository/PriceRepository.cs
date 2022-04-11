using DeliVeggie.Price.Infrastructure.Base;
using DeliVeggie.Price.Infrastructure.DbConfig;
using DeliVeggie.Price.Infrastructure.Entity;
using DeliVeggie.Price.Infrastructure.Interface;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Price.Infrastructure.Repository
{
    public class PriceRepository : BaseRepository, IPriceRepository
    {
        private IConfiguration _config;
     
        public PriceRepository(
            IConfiguration config,
                                  IPriceDatabaseSettings dbsetting
                                  ) : base(dbsetting)
        {
            _config = config;
        }
        public async Task<PriceReductionEntity> GetReductionAsync(int DayOfWeek)
        {
            var priceReduction = await _priceReduction.Find<PriceReductionEntity>(price => price.DayOfWeek == DayOfWeek).FirstOrDefaultAsync();
       
            return priceReduction;

        }
    }
}
