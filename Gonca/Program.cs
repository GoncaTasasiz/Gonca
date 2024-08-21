using System;
using System.ComponentModel.Design;

namespace Gonca 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //type safety = tip guvenligi
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalis butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artis butonu");
            }
            else 
            { 
                Console.WriteLine("degismedi butonu");
            }

            if (sistemeGirisYapmisMi == true)

            {
                Console.WriteLine("kullanici ayarlari butonu");

            }
            else
            {
                Console.WriteLine("giris yap butonu");

            
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
