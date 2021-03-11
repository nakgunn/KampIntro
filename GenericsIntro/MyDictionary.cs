using System;
using System.Collections.Generic;
namespace GenericsIntro
{
    public class MyDictionary<Key, Value>
    {

        Key[] keyArray;  Value[] valArray;

        Key[] tempKey;   Value[] tempValue;
        public MyDictionary()
        {
            keyArray = new Key[0];
            valArray = new Value[0];
        }
        public void Add(Key k, Value v)
        {
            tempKey = keyArray;  tempValue = valArray; // Gerçek dizilerimizin referanslarını tempKey ve tempValue isimli dizilerde tuttuk.

            keyArray = new Key[keyArray.Length + 1]; // keyArray dizisine yeni referans aldık ve dizinin eleman sayısını 1 arttırdık.
            valArray = new Value[valArray.Length + 1]; 

            for (int i = 0; i < tempKey.Length; i++)
            {
                keyArray[i]=tempKey[i]; // Eleman sayısı artmış olan keyArray'in önceki referansını -tempKey'den- aldık. Eski dizi elemanlarını yerleştirdik.
            }
            keyArray[keyArray.Length - 1] = k; // keyArray'in son index'ine Add metodundan gelen parametreyi yerleştirdik. 

            for (int i = 0; i < tempValue.Length; i++)
            {
                valArray[i] = tempValue[i];   
            }
            valArray[valArray.Length - 1] = v;

        }

        public int Count => keyArray.Length; // Class'ımıza Count özelliği ekledik. Tek satırlık get metodunun yerine alternatif yazım kullandık. 

        public void List()
        {
            for (int i = 0; i < keyArray.Length; i++)
            {
                Console.WriteLine(keyArray[i] + " " + valArray[i]);
            }
        }
    }

}

