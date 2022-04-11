using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Products.Domain
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductItem>> GetProductsAsync();

        Task<ProductItem> GetProductsByIdAsync(string id);

       
    }


    }

