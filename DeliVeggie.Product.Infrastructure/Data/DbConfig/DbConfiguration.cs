using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeliVeggie.Product.Infrastructure.Data.Model;
using DeliVeggie.Products.Infrastructure.Data.Entity;
using Microsoft.Extensions.Configuration;
using MongoDB;
using MongoDB.Driver;

namespace DeliVeggie.Products.Infrastructure.Data.DbConfig
{
    public class DbConfiguration

    {

        protected MongoClient Client;
        protected IMongoDatabase Database;

        protected readonly IMongoCollection<ProductEntity> _product;

        public DbConfiguration(IProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _product = database.GetCollection<ProductEntity>(settings.PrdouctsCollectionName);
        }

    }
}
