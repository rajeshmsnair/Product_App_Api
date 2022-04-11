using DeliVeggie.Products.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliVeggie.Product.Domain.Test
{

    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void Constructor_ThrowsException_WhilePassingNullParams()
        {
            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new ProductService(null));
        }

   

        [TestMethod]
        public async Task Test_GetProducts_Success()
        {
            //Arrange
            var mockProductRepo = new Mock<IProductRepository>();
            var serviceInstance = new ProductService(mockProductRepo.Object);
            mockProductRepo.Setup(x => x.GetProductsAsync()).Returns(Task.FromResult(GetProducts()));

            //Act 
            var result = await serviceInstance.GetProductsAsync();

            //Assert
            mockProductRepo.Verify(x => x.GetProductsAsync(), Times.Exactly(1));
            Assert.AreEqual(GetProducts().ToList().First().Id, result.ToList().First().Id);
            Assert.AreEqual(GetProducts().ToList().First().Price, result.ToList().First().Price);
            Assert.AreEqual(GetProducts().ToList().First().Name, result.ToList().First().Name);
            Assert.AreEqual(GetProducts().ToList().First().EntryDate, result.ToList().First().EntryDate);
            Assert.AreEqual(GetProducts().ToList().Count(), 2);
        }
        [TestMethod]
        public async Task Test_GetProductById_Success()
        {
            //Arrange
            string Id = "RS123455";
            var mockProductRepo = new Mock<IProductRepository>();
            var serviceInstance = new ProductService(mockProductRepo.Object);
            mockProductRepo.Setup(x => x.GetProductsByIdAsync(Id)).Returns(Task.FromResult(GetProductById(Id)));
            
            //Act 
            var result = await serviceInstance.GetProductByIdAsync(Id);

            //Assert
            mockProductRepo.Verify(x => x.GetProductsByIdAsync(Id), Times.Exactly(1));
            Assert.AreEqual(GetProductById(Id).Id, result.Id);
            Assert.AreEqual(GetProductById(Id).Price, result.Price);
            Assert.AreEqual(GetProductById(Id).Name, result.Name);
            Assert.AreEqual(GetProductById(Id).EntryDate, result.EntryDate);
          
        }

        private IEnumerable<ProductItem> GetProducts()
        {
            var products = new List<ProductItem>();
            products.Add(new ProductItem
            {
                Id = "RS123455",
                Name = "Buger",
                EntryDate = new DateTime(),
                Price = 100,

            });
            products.Add(new ProductItem
            {
                Id = "1234567",
                Name = "Pizza",
                EntryDate = new DateTime(),
                Price = 300,

            });
            return products;
        }
        private ProductItem GetProductById(string Id)
        {
     
            return GetProducts().ToList().Find(x=>x.Id== "RS123455") ;
        }
    }
}


