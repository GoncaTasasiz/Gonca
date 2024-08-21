
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elmasi";
            product1.Renk = "Kirmizi";
            product1.StokAdeti = 56;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Karpuz";
            product2.Fiyati = 15;
            product2.Aciklama = "Diyarbakir Karpuzu";
            product2.Renk = "Yesil";
            product2.StokAdeti = 55;

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products) 
            {
                Console.WriteLine(product.Id + " ; " + product.Adi +" ; " + product.Fiyati +" ; " +product.Aciklama);

            }

            Console.WriteLine("---------Methods----------------------");

            CartManager cartManager = new CartManager();
            
            
            cartManager.Ekle(product1);
            cartManager.Ekle(product2);
            cartManager.Ekle(product1);
            cartManager.Ekle(product2);

            cartManager.Ekle2("Elma", "Amasya Elmasi", 15);
            cartManager.Ekle2("Cilek", "Kirmizi Cilek", 25);

            cartManager.Ekle3("Tarsus", "Guzel Sehir");
            

        }
    }
}
