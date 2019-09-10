using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    delegate double Sum(int x, int i);

    static void Main(string[] args)
    {
        Sum ans = (x, i) => ((Math.Pow(x, 5)) * (Math.Pow(i, 5))) * 1.0 / 120;
        double answer = 0;
        for (int i0 = 1; i0 <= 5; ++i0)
        {
            Console.WriteLine(ans(2, i0));
        }
        
        Console.Read();
    }
   
}

