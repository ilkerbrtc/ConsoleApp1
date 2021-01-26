using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            //array - dizi 
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java" };
            for (int i = 0; i < kurslar.Length; i++)           //DÖNGÜLER = i başlangıç sayısı, i 10 dan küçükse i yi 1 arttır. Dögü tamamlana kadar devam eder. 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("SAYFA SONU");
            Console.WriteLine("2.Sayfa");

            foreach (string kurs in kurslar)                // foreach diziler için tekrar dolaşmak için
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
