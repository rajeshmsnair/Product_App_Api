using AutoMapper;
using DeliVeggie.Products.Domain;
using DeliVeggie.Products.Infrastructure.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliVeggie.Product.Api.MappingProfile
{
    public class AutoMapperProfile:Profile
    {
       
        public AutoMapperProfile()
        {
          
            CreateMap<ProductEntity, ProductItem>();

        }
    }
}
