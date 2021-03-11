using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        { //GenericTipi<DeğerinTipi> değerin adı = yeni string tipinde List tanımla.
            List<string> isimler = new List<string> {"Necati","Mehmet","Mert","Oğuzhan" };
            isimler.Add("İbrahim");
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            

            


        }
    }
}
