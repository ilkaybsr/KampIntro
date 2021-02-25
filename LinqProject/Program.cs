using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category {CategoryId =2, CategoryName = "Telefon" },

            };

            List<Product> products = new List<Product> 
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram ", UnitPrice=10000, UnitStock=5 },
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram ", UnitPrice=8000, UnitStock=3 },
                new Product{ProductId=3, CategoryId=1, ProductName="Hp Laptop",QuantityPerUnit="8 GB Ram ", UnitPrice=6000, UnitStock=2 },
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram ", UnitPrice=5000, UnitStock=15 },
                new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon",QuantityPerUnit="4 GB Ram ", UnitPrice=8000, UnitStock=0 },

            };

            Console.WriteLine("Algoritmik----------");
            foreach (var product in products)
            {
                if (product.UnitPrice >5000 && product.UnitStock >3)
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("Linq-----------");

            var result = products.Where(p=>p.UnitPrice>5000 && p.UnitStock>3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);

            }

            GetProducts(products);
        }

        static List<Product> GetProducts(List<Product> products) 
        {
            List<Product> filteredProduct = List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitStock > 3)
                {
                    filteredProduct.Add(product);
                }
            }
            return filteredProduct;
        }

        private static List<T> List<T>()
        {
            throw new NotImplementedException();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId{ get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
