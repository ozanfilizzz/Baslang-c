using System;

namespace DenemeCEngin
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //Do not repeat yourself
            //Burada ki kategori etiketi aslında bir değer tutucu yani takma isim (*alias)

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }

            else
            {
                Console.WriteLine("Sabit Ok");
            }

            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }


            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);







        }
    }
}
