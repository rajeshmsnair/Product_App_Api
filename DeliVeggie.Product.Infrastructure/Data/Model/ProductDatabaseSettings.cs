using System;
using System.Collections.Generic;
using System.Text;

namespace DeliVeggie.Product.Infrastructure.Data.Model
{
    public class ProductDatabaseSettings: IProductDatabaseSettings
    {

        public string PrdouctsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IProductDatabaseSettings
    {
        public string PrdouctsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
