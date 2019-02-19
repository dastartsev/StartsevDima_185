using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_2
{
    class IntegerList
    {
        private int[] list;
        private int _size = 0;
        public static readonly Random rnd = new Random();

        public  IntegerList(int size)
        {
            list = new int[size];
        }

        public void Randomize()
        {
            for (int i = 0; i < list.Length; ++i)
            {
                list[i] = rnd.Next();
            }
        }

        public void Print()
        {
            for (int i = 0; i < list.Length; ++i)
            {
                Console.WriteLine($"{i}:\t {list[i]}");
            }
        }
        
        public void IncreaseSize()
        {
            Array.Resize(ref list, list.Length + 3);
        }

        public void AddElement(int new_Val)
        {
            if (_size == list.Length)
            {
                IncreaseSize();
            }
            list[_size] = new_Val;
            ++_size;
        }

        public void RemoveFirst(int val)
        {
            int pos = -1;

            for (int i = 0; i < list.Length; ++i)
            {
                if (list[i] == val)
                {
                    pos = i;
                    break;
                }
            }

            if (pos != -1)
            {
                for (int i = pos; i < list.Length - 1; ++i)
                {
                    list[i] = list[i + 1];
                }
                list[list.Length - 1] = 0;
                --_size;
            }
        }
        public void RemoveAll(int val)
        {
            int pos, amount = 0;

            for (int i = 0; i < list.Length; ++i)
            {
                if (list[i] == val)
                {
                    pos = i;
                    ++amount;
                    for (int j = pos; j < list.Length - amount; ++j)
                    {
                        list[j] = list[j + 1];
                    }
                    list[list.Length - amount] = 0;
                    --_size;
                    --i;
                }
            }
        }
        
    }
}
