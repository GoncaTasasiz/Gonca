using System;
using System.ComponentModel.Design;
using System.Reflection.Emit;

namespace Gonca
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;
            kurs1.yildiz = 5;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 64;
            kurs2.yildiz = 4;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "Yasin";
            kurs3.IzlenmeOrani = 78;
            kurs3.yildiz = 5;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Gonca";
            kurs4.IzlenmeOrani = 97;
            kurs4.yildiz = 4;

            //Console.WriteLine(kurs1.KursAdi + " ; " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +" ; " + kurs.Egitmen +" ; " +kurs.IzlenmeOrani +" ; " + kurs.yildiz);

            }

        }
    }    
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen  { get; set; }
        public int IzlenmeOrani { get; set; }
        public int yildiz { get; set; }


    }
    
}

