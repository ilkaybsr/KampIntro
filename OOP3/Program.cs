using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager  konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager);


            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager , konutKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            
            
        }
    }
}
