using DeliVeggie.Products.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeliVeggie.Products.Domain
{
    public class ProductItem: BaseEntity
    {
     
        public string Name { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal Price { get; set; }
       
    }
}

