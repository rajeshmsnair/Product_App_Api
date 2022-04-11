
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static DeliVeggie.Products.Infrastructure.Shared.ProductConstants;
using DeliVeggie.Products.Domain;
using AutoMapper;
using DeliVeggie.Products.Infrastructure.Data.Entity;
using DeliVeggie.Products.Infrastructure.Data.Extensions;
using DeliVeggie.Products.Infrastructure.Data.DbConfig;
using DeliVeggie.Product.Infrastructure.Data.Model;
using System.Net.Http;
using System.Net.Http;
using System.Net.Http.Headers;
namespace DeliVeggie.Products.Infrastructure.Data.Repository
{
    public class ProductRepository: BaseRepository, IProductRepository

    {
        private IMapper _mapper;
   
        private HttpClient _httpClient = new HttpClient();
        private IConfiguration _config;
        private  string priceApiUrl="";
        public ProductRepository( IConfiguration config, 
                                  IMapper mapper, 
                                  IProductDatabaseSettings dbsetting
                                  ) : base(dbsetting)
        {
            _mapper = mapper;
            _config = config;
             priceApiUrl = _config.GetSection("ApiPath").GetSection("Price.Api").Value;
        }
       
        public async Task<IEnumerable<ProductItem>> GetProductsAsync()
        {
            var products =await _product.Find(book => true).ToListAsync();
            return products.EntityToProductsDomain(_mapper);
   
        }

        public async Task<ProductItem> GetProductsByIdAsync(string id)
        {

            var product= await _product.Find<ProductEntity>(prod => prod.Id == id).FirstOrDefaultAsync();
            double reduction = await GetPriceReduction(product);
            product.EntityPriceReductionMap(reduction);
            return product.EntityToProductDomain(_mapper);


        }

        public async Task<double> GetPriceReduction(ProductEntity product)
        {
           
            int weekDay = (int)product.EntryDate.DayOfWeek;

            priceApiUrl += "GetDiscount/" + weekDay;
            HttpResponseMessage response = await _httpClient.GetAsync(priceApiUrl);
            if (response.IsSuccessStatusCode)
            {
                var reduction = await response.Content.ReadAsStringAsync();
                return Convert.ToDouble(reduction);
            }
            throw new Exception("No Response");
        }

    }
}
