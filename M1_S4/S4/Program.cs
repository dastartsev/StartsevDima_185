using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{

    public static int Input()
    {
        int temp;

        while (!int.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Incorrect input, try again");
        }
        return temp;
    }

    public static double DInput()
    {
        double temp;

        while (!double.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Incorrect input, try again");
        }
        return temp;
    }

    public static void T1()
    {
        int a = Input();
        int[] ar = new int[16];
        int num = 0;
        for (int i = 0; i < 16; ++i)
        {
            ar[i] = a % 10;
            if (a != 0)
                ++num; 
            a /= 10;
        }

        Array.Sort(ar);

        for (int i = 15; i >= 15 - num; --i)
        {
            Console.Write(ar[i] + " ");
        }
    }

    public static void DZ1()
    {
        for (int a = 1; a < 20; ++a)
        {
            for (int b = 1; b < 20; ++b)
            {
                for (int c = 1; c < 20; ++c)
                {
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine(a + " " + b + " " + c);
                    }
                }
            }
        }
        int i = Input();
    }

    static void Main(string[] args)
    {
        do
        {
            //T1();
            DZ1();
        } while (true);
    }

}
