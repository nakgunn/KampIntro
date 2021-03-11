using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {                
               Console.WriteLine(urun.Adi + " " + urun.Fiyati + " "  +urun.Aciklama);
            }

            Console.WriteLine("----------------------Metotlar----------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}
