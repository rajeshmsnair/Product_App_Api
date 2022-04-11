using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Products.Domain.Interfaces
{
   public interface IProductRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetProductsAsync();

        Task<TEntity> GetProductsByIdAsync();
    }
}
