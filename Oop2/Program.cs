using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Adı = "İlker";
            musteri1.Soyadı = "Barutçu";
            musteri1.TcNo = "30320160498";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 7;
            musteri2.MusteriNo = "190754";
            musteri2.SirketAdı = "Kodlama.io";
            musteri2.VergiNo = "2021";

            Musteri musteri3 = new Musteri();
            Musteri musteri4 = new Musteri();

            MusteriManager musteriManager = new MusteriManager();
        }
    }
}
