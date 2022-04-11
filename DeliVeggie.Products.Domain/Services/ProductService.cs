using DeliVeggie.Products.Domain.Entities.Products;
using DeliVeggie.Products.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Products.Domain.Services
{
   public class ProductService : IProductService
    {
        private readonly IProductRepository<Product> _repository;

        public ProductService(IProductRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            //LU : await keyword
            return await _repository.GetProductsAsync();
        }

        public async Task<Product> GetProductByIdAsync()
        {
            return await _repository.GetProductsByIdAsync();
        }
    }
}
