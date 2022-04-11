using DeliVeggie.Price.Infrastructure.Entity;
using DeliVeggie.Price.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Price.Infrastructure.Service
{
    public class PriceService: IPriceService
    {
        IPriceRepository _priceRepository;
        public PriceService(IPriceRepository priceRepository)
        {
            _priceRepository = priceRepository;
        }

        public async Task<double> getReductionByWeekDay(int weekDay)
        {
          var priceReduction= await _priceRepository.GetReductionAsync(weekDay).ConfigureAwait(false);
          return priceReduction.Reduction;
        }
    }
}
