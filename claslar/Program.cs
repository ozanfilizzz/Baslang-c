using System;

namespace claslar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazılım Geliştirici Yetiştirelim!";
            kurs1.EgitmenAdi = "Ozan Fiiz";
            kurs1.Izlenmeorani = 35;
            kurs1.Fiyati = 99;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Javacı Yetiştirelim!";
            kurs2.EgitmenAdi = "Bekir Fiiz";
            kurs2.Izlenmeorani = 15;
            kurs2.Fiyati = 55;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Frontend Yetiştirelim!";
            kurs3.EgitmenAdi = "Nazlı Fiiz";
            kurs3.Izlenmeorani = 75;
            kurs3.Fiyati = 90;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.EgitmenAdi + " " + kurs1.Fiyati + " " );

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine ( kurs.KursAdi + " " + kurs.EgitmenAdi + "  " + " " + kurs.Fiyati);

            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string EgitmenAdi { get; set; }
        public int Izlenmeorani { get; set; }
        public int Fiyati { get; set; }



    }




}

