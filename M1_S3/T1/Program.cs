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
        int temp = Input();
        Console.WriteLine( temp > 0 && temp <= 3 ? "Неудовлетворительно" : (temp >=4 && temp <= 5 ? "Удоволетворительно": (temp >= 6 && temp <= 8 ? "Хорошо":"Отлично" ) )   );
    }

    public static void T7()
    {
        double a = DInput(), b = DInput(), c = DInput();
        if(!Solver(a, b, c))
        {
            Console.WriteLine("No roots");
        }

    }

    public static void DZ1()
    {
        for (int i = 111; i < 1000; i+= 111)
        {
            int temp = i;
            int tempo = 0;
            for (int j = 1; temp > 0; ++j)
            {
                temp -= j;
                tempo = j;
            }

            if (temp == 0)
            {
                Console.WriteLine($"{i} = 1 + 2 + 3 + ... + {tempo - 2} + {tempo - 1} + {tempo}");//666
            }
            
        }
    }

    public static void DZ2()
    {
        int num = Input();
        int ans = 0;
        while (num != 0)
        {
            ans = ans * 10 + num % 10;
            num /= 10;
        }
        Console.WriteLine(ans);
    }

    static void Main(string[] args)
    {
        do
        {
            //T1();
            //T7();
            //DZ1();
            DZ2();




        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }


    public static bool Solver(double a, double b, double c)
    {
        double D = b * b - 4 * a * c;
        if (D > 0)
        {
            Console.WriteLine($"Fisrt x = {(b - Math.Sqrt(D)) / (2 * a)}, Second x = {(b - Math.Sqrt(D)) / (2 * a)}");
            return true;
        }
        else if (D == 0)
        {
            Console.WriteLine($" x = {b / (2 * a)} ");
            return true;
        }
        else
            return false;
    }

}
