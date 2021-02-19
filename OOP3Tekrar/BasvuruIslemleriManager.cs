using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3Tekrar
{
    class BasvuruIslemleriManager
    {
        public void BasvuruyuYap(IKrediServis krediServis) 
        {
            krediServis.Hesapla();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediServis>krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
