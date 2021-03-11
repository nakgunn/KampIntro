using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // tipini ne verirsen ver kabul edecek.
    {
        T[] items; // items isimli T dizisi TANIMLA -> Stack'te
        public MyList() // Constructor - Class new'lenince otomatik çalışacak. 
        {
            items = new T[0]; // MyList<T> new'lenmeden önce stack'te TANIMLANAN items dizisini, Heap'te OLUŞTUR. 0 elemanlı bir items dizisine referans verildi.
        }
        public void Add(T item) // Yukarıda classımızda verilen T tipi ne ise burda da o tipten olsun.
        {
            T[] tempArray = items; // items'in referans numarasını tempArray dizisinde tut.
            items = new T[items.Length+1]; // items'e yeni refereans numarası al ve eleman sayısını bir arttır(index'ini)
            
            for (int i = 0; i < tempArray.Length; i++) // tempArray'in index numaralarını tek tek dön.
            {
                items[i] = tempArray[i]; // tempArray'in her bir index'ine karşılık gelen değeri items'in o index'teki elemanına ver.
            }
            items[items.Length - 1] = item; // items'in son index'ine parametre olarak gelen item'ı ekle.
        }

        public int Count => items.Length;
    }

}

