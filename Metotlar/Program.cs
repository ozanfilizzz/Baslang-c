using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.UrunAdi = "Matematik";
            urun1.Fiyati = 100;
            urun1.Aciklama = "TYT Matematik Hazırlık";
            urun1.Süresi = "1 saat";
            urun1.Id = 0001;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Türkçe";
            urun2.Fiyati = 120;
            urun2.Aciklama = "TYT Türkçe Hazırlık";
            urun2.Süresi = "1 saat";
            urun2.Id = 0002;

            Urun[] urunler = new Urun[] { urun1,urun2};

            //type-safety

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Süresi);

            }


            Console.WriteLine("--------------Metotlar----------");
            
            // instance - örnek
            // encapsulation - kapsülleme çalışması

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Maydonuz", "Doğal Sebze", 12, 8);
            sepetManager.Ekle2("Çilek", "Doğal Bahçeden", 12, 9);


        }
    }
}
