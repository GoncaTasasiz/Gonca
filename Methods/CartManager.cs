using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

    class CartManager

    {

        public void Ekle(Product product) 
        {
            Console.WriteLine("Sepete eklendi : " + product.StokAdeti);

        }
        public void Ekle2(string productAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + aciklama + " " + productAdi + " " +fiyat + " Bak nasil da yazdi");

        }
        public void Ekle3(string cityAdi, string aciklama)
        {
            Console.WriteLine(cityAdi + "'a hosgeldiniz." + " " +"Bu sehir" + " " + aciklama + ".");

        }
    }
}
        