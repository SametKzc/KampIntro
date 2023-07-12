using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T1, T2>
    {
        T1[] keys;
        T2[] items;

        public MyDictionary()
        {
            keys = new T1[0];
            items = new T2[0];
        }
        public void Add(T1 key, T2 item)
        {
            T1[] tempKeys = keys;
            T2[] tempItems = items;

            keys = new T1[keys.Length + 1];
            items = new T2[items.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                items[i] = tempItems[i];

            }
            keys[keys.Length - 1] = key;
            items[items.Length - 1] = item;
        }

        public void getIndexAt(int index)
        {
            Console.WriteLine("Key: " + keys[index] + "\n" + "Value: " + items[index]);
        }
        public void setIndexAt(int index, T1 key, T2 item)
        {
            keys[index] = key;
            items[index] = item;

        }
        public void printDictionary()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key: " + keys[i] + "\n" + "Value: " + items[i] + "\n" + "---------------------");
            }

        }

    }
}
