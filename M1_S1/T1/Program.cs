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

    public static double dInput()
    {
        double temp;

        while (!double.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Incorrect input, try again");
        }
        return temp;
    }


    static void Main(string[] args)
    {
        do
        {
            int ch = Input();

            if (ch == 10)
            {
                string[] str = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    str[i] = Console.ReadLine();
                }
                Console.WriteLine(str[0] + "!" + str[1] + "!" + str[2]);
                Console.WriteLine("-" + str[0] + "-\n-" + str[1] + "-\n-" + str[2] + "-");
            } else if (ch == 11)
            {
                int i = Input();
                Console.WriteLine((char) i);
            } else if (ch == 12)
            {
                double k1 = dInput(), k2 = dInput();

                Console.WriteLine(Math.Sqrt(k1 * k1 + k2 * k2));

            }







        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }
}
