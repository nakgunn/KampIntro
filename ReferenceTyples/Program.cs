using System;
using System.Collections.Generic;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("Manisa");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İzmir");
            sehirler2.Add("Ankara");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);

        }
    }

    class MyList<T>
    {

        T[] dizi;
        T[] geciciDizi;
        public MyList()
        {
            dizi = new T[0];
        }
        public void Add(T item)
        {
            geciciDizi = dizi;   // dizi'nin referans numarasını geçici diziye atadık
            dizi = new T[dizi.Length+1];

            for (int i = 0; i < geciciDizi.Length; i++)
            {
                dizi[i] = geciciDizi[i];
            }

            dizi[dizi.Length - 1] = item;
        }

        public int Count => dizi.Length; // Sadece get işlemi döndürdük. .koyduktan sonra Count çıkacak.

    }

}
