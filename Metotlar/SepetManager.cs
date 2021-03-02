using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager  //manager - bir operasyon tutuyor demektir.
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);  //burda yapılan değişiklikler bütün sayfalarda gerçekleşir.           
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
