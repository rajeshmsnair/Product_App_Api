﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliVeggie.Price.Infrastructure.Entity
{
   public class PriceReductionEntity
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int DayOfWeek { get; set; }
        public double Reduction { get; set; }

    }
}
