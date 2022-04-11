using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Products.Infrastructure.Data.Interfaces
{
    public interface IRepository<TEntity> 
    {
        Task<IEnumerable<TEntity>> GetProductsAsync();

        Task<TEntity> GetProductsByIdAsync();


    }
}
