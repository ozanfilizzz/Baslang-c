using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming conventon
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Ürünü Sepete Başarıyla Eklediniz : " + urun.UrunAdi );



        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {

            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urunAdi + aciklama + fiyat + stokAdedi);



        }



    }
}
