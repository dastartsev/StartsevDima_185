using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_К_ЭКР
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3,3] ;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int i0 = 0; i0 < a.GetLength(1); i0++)
                {
                    a[i, i0] = i + i0;
                }
            }

            int[,] b = (int[,])a.Clone();
            Console.WriteLine(b[0,1]);
            a[0, 1] = 100;
            Console.WriteLine(b[0, 1]);

        }
    }
}
