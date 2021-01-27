using System;

namespace MatematikTekra
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslemMi dortIslemMi = new DortIslemMi();
            dortIslemMi.Topla(5, 6);

            dortIslemMi.Topla(6, 9);
        }
    }
}
