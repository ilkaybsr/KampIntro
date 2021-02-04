using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1Tekrar
{
    class ProductManagerTekrar
    {
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + "Eklendi.");
        }

        public void UpDate(Product product) 
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }

        
    }
}
