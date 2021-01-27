using System;

namespace DersTekrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }

            else
            {
                Console.WriteLine("Değişmedi Oku");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullannıcı Ayarları Butonu");

            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }



            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);


            




        }
    }
}   

