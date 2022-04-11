using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace DeliVeggie.Products.Infrastructure.Data.Entity
{
    public class ProductEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
      
        public string Name { get; set; }
    
        public DateTime EntryDate { get; set; }
    
        public decimal Price { get; set; }
    }
}
