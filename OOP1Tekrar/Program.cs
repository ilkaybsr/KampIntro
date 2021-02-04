using System;

namespace OOP1Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitsPrice = 500;
            product1.UnitsPrice = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitsPrice = 35 };

            ProductManagerTekrar productManagerTekrar = new ProductManagerTekrar();
            productManagerTekrar.Add(product1);
            Console.WriteLine(product1.ProductName);
        }
    }
}
