using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string KategoriEtiketi = "Deneme" ;
            //int KategoriSayısı = 54 ;
            //int ogrenciSayısı = 54000 ;
            //double faizOranı = 1.54 ;
            //bool sistemeGirişYapmışMı = true ;     
            double dolarDün = 7.41;
            double dolarBugün = 7.41;
            if (dolarDün < dolarBugün)
            {
                Console.WriteLine("Dolar artış butonu");
            }
            else if (dolarBugün < dolarDün)
            {
                Console.WriteLine("Dolar azalış butonu");
            }
            else
            {
                Console.WriteLine("Dolar sabit butonu");
            }
            //if (sistemeGirişYapmışMı == true)
            //{
            //    Console.WriteLine("Kullanıcı Ayarları butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}



            //Console.WriteLine(KategoriEtiketi);
        }
    }
}
