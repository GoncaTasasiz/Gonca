using System;
using System.ComponentModel.Design;

namespace Gonca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"yazilim","java","c#","c++" };


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);  
            }

            for (int i = 0; i < kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);  
            
            } 
        }
    }
}

