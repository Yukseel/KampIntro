using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs", "Java", "C#","Phyton" };

            for (int i = 0; i<kurslar.Length; i++)  //i sayaç anlamında 1er 1er artırarak 10a kadar çalışır.
            {
                Console.WriteLine(kurslar[i]);      //length - eleman sayısı
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)  //dizi temelli yapıları tek tek dönmeye yarar
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
