using System;
using System.Collections.Generic;

namespace OOP3Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediServis ihtiyacKrediServis = new IhtiyacKrediServis();
            IKrediServis taşıtKrediServis = new TaşıtKrediServis();
            IKrediServis konutKrediServis = new KonutKrediServis();

            BasvuruIslemleriManager basvuruIslemleriManager = new BasvuruIslemleriManager();
            //basvuruIslemleriManager.BasvuruyuYap(ihtiyacKrediServis);

            List<IKrediServis> krediler = new List<IKrediServis>() { ihtiyacKrediServis, taşıtKrediServis};

            basvuruIslemleriManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
