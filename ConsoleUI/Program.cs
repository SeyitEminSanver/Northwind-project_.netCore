﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

             ProductTest();
            // CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            var result = productManager.GetProductDetails();
            if (result.Succes)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "" + product.CategoryName + "" + product.UnitsInStock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}