using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "İlker";
            int yaş = 23;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 54;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "C++";
            kurs2.Egitmen = "İlker BARUTÇU";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egitmen = "Berkay BİLGİN";
            kurs3.IzlenmeOrani = 98;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı : " + kurs.KursAdı + "" + "Kurs Hocası : " + kurs.Egitmen);
            }





        }
    }
    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}   
