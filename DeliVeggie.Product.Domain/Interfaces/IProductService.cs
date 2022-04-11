using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Products.Domain.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductItem>> GetProductsAsync();

        Task<ProductItem> GetProductByIdAsync(string id);
    }
}
