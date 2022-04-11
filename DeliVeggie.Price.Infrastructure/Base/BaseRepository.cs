using DeliVeggie.Price.Infrastructure.DbConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliVeggie.Price.Infrastructure.Base
{
  
    public class BaseRepository : DbConfiguration
    {

        public BaseRepository(IPriceDatabaseSettings dbsetting) : base(dbsetting)
        {

        }

    }
}
