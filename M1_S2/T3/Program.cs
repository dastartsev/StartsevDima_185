using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        public static void swap(ref double x, ref double y, ref double z)
        {
            double max = x > y ? (x > z ? x : z) : (y > z ? y : z);
            double min = x < y ? (x < z ? x : z) : (y < z ? y : z);
            double mid = x > y ? (x < z ? x : (z > y ? z : y)) : (y < z ? y : (z > x ? z : x));
            x = min;
            y = mid;
            z = max;
        }
        
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            string s = Console.ReadLine();
            string[] str = s.Split();
            x = int.Parse(str[0]);
            y = int.Parse(str[1]);
            z = int.Parse(str[2]);


            swap(ref x, ref y, ref z);

            Console.WriteLine(x + " " + y + " " + (z).ToString("F4"));
            x = Console.Read();
        }
    }
}
