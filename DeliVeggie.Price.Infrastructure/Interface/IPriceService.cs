using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Price.Infrastructure.Interface
{
   public  interface IPriceService
    {
       public Task<double> getReductionByWeekDay(int weekDay);
    }
}
