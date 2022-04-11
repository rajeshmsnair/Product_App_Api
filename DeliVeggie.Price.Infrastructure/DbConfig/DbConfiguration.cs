using DeliVeggie.Price.Infrastructure.Entity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliVeggie.Price.Infrastructure.DbConfig
{
  public  class DbConfiguration
    {

        protected MongoClient Client;
        protected IMongoDatabase Database;

        protected readonly IMongoCollection<PriceReductionEntity> _priceReduction;

        public DbConfiguration(IPriceDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _priceReduction = database.GetCollection<PriceReductionEntity>(settings.PriceCollectionName);

        }
    }
}
