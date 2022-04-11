using DeliVeggie.Products.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Products.Domain
{
    public class ProductService : IProductService

    {


        private readonly IProductRepository _repository;


        public  ProductService(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository)); ;
        }
        public async Task<IEnumerable<ProductItem>> GetProductsAsync()
        {
            //LU : await keyword
            return await _repository.GetProductsAsync();
        }

        public async Task<ProductItem> GetProductByIdAsync(string id)
        {
            return await _repository.GetProductsByIdAsync(id);
        }
    }
}
