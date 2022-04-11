using System;
using System.Collections.Generic;
using System.Text;

namespace DeliVeggie.Price.Infrastructure.DbConfig
{
   

    public class PriceDatabaseSettings : IPriceDatabaseSettings
    {

        public string PriceCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
       
    }

    public interface IPriceDatabaseSettings
    {
        public string PriceCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}

