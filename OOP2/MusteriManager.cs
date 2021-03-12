using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class MusteriManager
    {
        // Polimorphizm
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.MusteriNo);
        }
    }
}
