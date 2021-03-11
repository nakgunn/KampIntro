using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            bool sistemeGirisYapildiMi = false;

            double dolarDun = 7.45;
            double dolarBugun = 7.60;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("düşüşte");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("yükselişte");
            }
            else if (dolarDun==dolarBugun)
            {
                Console.WriteLine("sabit");
            }

                    //if (sistemeGirisYapildiMi==true)
                    //{
                    //    Console.WriteLine("Hoşgeldin Admin");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Hoşgeldin Misafir");
                    //}
            

        }
    }
}
