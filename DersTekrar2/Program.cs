using System;

namespace DersTekrar2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılıım Geliştirici Kampı";
            string kurs2 = "Proglamlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

         
            string[] kurslar = new string[] { "Yazılıım Geliştirici Kampı" , "Proglamlamaya Başlangıç İçin Temel Kurs" ,"Java","C#"};




            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            Console.WriteLine("for bitti");


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine( "Sayfa Sonu Footer" );

        } 
    }
}
