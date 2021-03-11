using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C# Kursu";
            kurs1.Egitmen = "Necati Akgun";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Bilgi Güvenliği Kursu";
            kurs2.Egitmen = "Necati Akgun";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Sosyal Medya Yönetimi";
            kurs3.Egitmen = "Necati Akgun";
            kurs3.IzlenmeOrani = 77;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Google ADS";
            kurs4.Egitmen = "Necati Akgun";
            kurs4.IzlenmeOrani = 95;

            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " %" + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("Kurs:" + kurs.KursAdi + " Eğitmen:" + kurs.Egitmen + " %" + kurs.IzlenmeOrani + " tamamlandı.");
            }

            bool girisYapildiMi = true;

            string sonuc = girisYapildiMi ? "Yapıldı" : "Yapılmadı";

            Console.WriteLine(sonuc);

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
