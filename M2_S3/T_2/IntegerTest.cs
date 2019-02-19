using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_2
{
    class IntegerTest
    {
        private static IntegerList _list = new IntegerList(5);
        public static void Main()
        {
            _list.AddElement(5);
            _list.AddElement(6);
            _list.AddElement(6);
            _list.AddElement(6);
            _list.AddElement(6);
            _list.AddElement(111);
            _list.AddElement(6);
            _list.AddElement(6);
            _list.Print();
            Console.WriteLine();
            _list.RemoveAll(6);
            _list.Print();
            int a = Console.Read();

        }
    }
}
