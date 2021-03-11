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
            tempKey = keyArray;
            tempValue = valArray;
            keyArray = new Key[keyArray.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keyArray[i]=tempKey[i];
            }
            keyArray[keyArray.Length - 1] = k;

            valArray = new Value[valArray.Length + 1];
            for (int i = 0; i < tempValue.Length; i++)
            {
                valArray[i] = tempValue[i];   
            }
            valArray[valArray.Length - 1] = v;

        }

        public int Count => keyArray.Length;

    }

}

