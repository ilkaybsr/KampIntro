using System;

namespace Odev._2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.UrunAdi = "Pantolon";
            Product1.Bedeni = "S";
            Product1.Rengi = "Lacivert";
            Product1.Fiyati = 149.99;

            Product Product2 = new Product();
            Product2.UrunAdi = "Gömlek";
            Product2.Bedeni = "L";
            Product2.Rengi = "Beyaz";
            Product2.Fiyati = 219.99;

            Product Product3 = new Product();
            Product3.UrunAdi = "Elbise";
            Product3.Bedeni = "M";
            Product3.Rengi = "Siyah";
            Product3.Fiyati = 159.99;

            //dizi tanımlayalım
             Product[] Product = new Product[] { Product1, Product2, Product3 };

            //for (int i = 0; i < Product.Length; i++)
            //{
            //    Console.WriteLine(product[i].UrunAdi + ":" + Product[i].Bedeni + ":" + Product[i].Rengi + ":" + Product[i].Fiyati);
            //}


            //foreach (Product x in Product )
            //{
            //    Console.WriteLine(x.UrunAdi + ":" + x.Bedeni + ":" + x.Rengi + ":" + x.Fiyati);
            //}

            int i = 0;
            while (i<Product.Length)
            {
                Console.WriteLine(Product[i].UrunAdi + ":" + Product[i].Bedeni + ":" + Product[i].Rengi + ":" + Product[i].Fiyati);

                i++;
            }
        }
    }


    class Product
    {
        public string UrunAdi { get; set; }
        public string Bedeni { get; set; }
        public string Rengi { get; set; }
        public double Fiyati { get; set; }
    }
}
