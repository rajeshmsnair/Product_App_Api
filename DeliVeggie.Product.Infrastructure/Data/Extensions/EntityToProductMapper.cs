using AutoMapper;
using DeliVeggie.Products.Domain;
using DeliVeggie.Products.Infrastructure.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace DeliVeggie.Products.Infrastructure.Data.Extensions
{
    public static class EntityToProductMapper
    {
        public static IEnumerable<ProductItem> EntityToProductsDomain(this IEnumerable<ProductEntity> products, IMapper mapper)
        {
            return mapper.Map<IEnumerable<ProductItem>>(products);
        }
        public static ProductItem EntityToProductDomain(this ProductEntity product, IMapper mapper)
        {
            return mapper.Map<ProductItem>(product);
        }
        public static ProductEntity EntityPriceReductionMap(this ProductEntity _productItem, double reduction)
        {
            if (reduction != 0)
            {
                decimal afterReduction = _productItem.Price - (_productItem.Price * (Decimal)reduction / 100);
                _productItem.Price = afterReduction;
                return _productItem;
            }
            else
            {
                return _productItem;
            }

        }
    }
}
