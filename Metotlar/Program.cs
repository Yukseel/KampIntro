using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma","Karpuz" };

            Urun urun1 = new Urun();  //class tanımlamak için bunu yapmak gerekiyor.Buna örnek denir.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;          // class da bir ürün tanımlamak için sağ tarafında new ibaresi yazması gerekir.
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type-safe -- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("----------Metotlar---------");
            //instance - örnek(claas örneği)
            //encapsulation - kapsülleme (ayrı ayrı olan yapıyı bir düzene sokmak için kullanılır.)
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır armut", 12, 8);
        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practise..Sayfalarda ortak kodlar varsa metot haline getirilip kullanılır.
//metotlar tekrar tekrar kullanılabilen ortamlardır