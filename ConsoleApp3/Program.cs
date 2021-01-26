using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurslar = new Kurs();
            kurslar.kursAdı = "Pyhton";
            kurslar.kursEgitmen = "Engin Demirog";
            kurslar.ızlenmeOranı = 54;
            kurslar.kursDk = 200;


            Kurs kurslar2 = new Kurs();
            kurslar2.kursAdı = "C++";
            kurslar2.kursEgitmen = "Engin Demirog";
            kurslar2.ızlenmeOranı = 7;
            kurslar2.kursDk = 50;


            Kurs kurslar3 = new Kurs();
            kurslar3.kursAdı = "C#";
            kurslar3.kursEgitmen = "Engin Demirog";
            kurslar3.ızlenmeOranı = 75;
            kurslar3.kursDk = 45;

            Kurs[] list = new Kurs[] { kurslar, kurslar2, kurslar3 };
            foreach (var kurs in list)
            {
                Console.WriteLine(kurs.kursEgitmen + " : " + kurs.kursAdı + " " + kurs.ızlenmeOranı + " dakika izlendi" + " " + kurs.kursDk);
            }
        }
    }
}
