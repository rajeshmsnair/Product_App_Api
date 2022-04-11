using DeliVeggie.Products.Infrastructure.Data.DbConfig;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using DeliVeggie.Product.Infrastructure.Data.Model;

namespace DeliVeggie.Products.Infrastructure.Data.Repository
{
    public class BaseRepository:DbConfiguration
    {

        public BaseRepository(IProductDatabaseSettings dbsetting) :base(dbsetting)
        {

        }

    }
}
