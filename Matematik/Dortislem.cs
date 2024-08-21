using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Dortislem
    {
        public void Topla(int sayi1,int sayi2)

        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("sonuc:" + toplam);

        }
        public void Cikar(int sayi1, int sayi2)

        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine("sonuc:" + cikar);

        }
        public void Carp(int sayi1, int sayi2)

        {
            int carp = sayi1 * sayi2;
            Console.WriteLine("sonuc:" + carp);

        }
    }
}
