using DeliVeggie.Price.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Price.Infrastructure.Interface
{
   public interface IPriceRepository
    {
        Task<PriceReductionEntity> GetReductionAsync(int DayOfWeek);
    }
}
