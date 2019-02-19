using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{ 
    class Program
    {
        static int sum(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //    int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 }};
            //    Array.Resize(ref arr, 9);
            //    Console.WriteLine(arr[2][0]);
            Console.WriteLine(sum(2, 3));
            Console.ReadLine();

        }
    }
}
