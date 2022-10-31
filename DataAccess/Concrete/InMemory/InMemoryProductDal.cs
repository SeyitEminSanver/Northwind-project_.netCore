using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{CategoryId=1,ProductId=2,ProductName="Kamera",UnitPrice=25,UnitsInStock=5},
                new Product{CategoryId=2,ProductId=3,ProductName="Telefon",UnitPrice=555,UnitsInStock=10},
                new Product{CategoryId=2,ProductId=4,ProductName="Klavye",UnitPrice=35,UnitsInStock=20},
                new Product{CategoryId=2,ProductId=5,ProductName="Mouse",UnitPrice=45,UnitsInStock=7},
            };   
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ-Language Integrated Query
            //Lambda =>
            Product ProductToDelete = ProductToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(ProductToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

       
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün ID sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName=product.ProductName;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
        }


    }
}
