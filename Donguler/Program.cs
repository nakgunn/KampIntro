using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"C# Kursu", "Java Kursu", "Javascript Kursu" };
            for (int i = kurslar.Length-1; i >= 0; i--)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("---------------------------------------------------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
