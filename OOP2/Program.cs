using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "112233";
            musteri1.Adi = "Necati";
            musteri1.Soyadi = "Akgün";
            musteri1.TcNo = "11223344559";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "998877";
            musteri2.SirketAdi = "Kardeşler Kundura";
            musteri2.VergiNo = "45342635";

            MusteriManager musteriManager = new MusteriManager();
            // Polimorfizm
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);




        }
    }
}
