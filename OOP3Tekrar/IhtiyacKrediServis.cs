using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3Tekrar
{
    class IhtiyacKrediServis : IKrediServis
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı");

        }
    }
}
