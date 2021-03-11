using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(3);
            sayilar.Add(5);
            sayilar.Add(8);
           // Console.WriteLine(sayilar.Count);

            Dictionary<int, string> plakalar = new Dictionary<int, string>();
            plakalar.Add(01, "Adana");
            plakalar.Add(06, "Ankara");
            plakalar.Add(26, "Eskişehir");
            plakalar.Remove(01);
            Console.WriteLine(plakalar.Count + " adet il plaka kaydı bulundu");

            foreach (var plaka in plakalar)
            {
                Console.WriteLine(plaka.Key + " " + plaka.Value);
            }

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Bir");
            myDictionary.Add(9, "Dokuz");
            myDictionary.Add(45, "Kırkbeş");
            myDictionary.Add(99, "DoksanDokuz");
            int adet = myDictionary.Count;
            Console.WriteLine(adet);
           

        }
    }
}
