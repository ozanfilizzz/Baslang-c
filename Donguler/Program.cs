using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - Dizi 

            string[] kurslar = new string[] { "Yazılım Geliştiri Ol!", "Programlamaya Giriş Yapalım!", "Python Öğrenelim!", "java Öğrenelim!", "Ozan","Ücretsiz Deneme Dersi!" };
            
           
        
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar [i]);
            }

            Console.WriteLine("For Bitti! Sıra foreach'de");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("BölümSonu!");

        }
    }
}
