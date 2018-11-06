using System;

class Program
{

    static int bin_pow(int a, int pow)
    {
        if (pow == 0)
        {
            return 1;
        }
        else if (pow % 2 == 0)
        {
            int b = bin_pow(a, pow / 2);
            return  (b * b);
        } else
        {
            return  a * bin_pow(a , pow - 1);
        } 
    } 



    public static uint Input()
    {
        uint a;

        while (!uint.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Неверный ввод, повторите попытку: ");
        }

        return a;
    }

    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine(bin_pow(2, 7));


        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }

}
/*String.Format("{0:0.0}", 0.0);          "0.0"
String.Format("{0:0.#}", 0.0);            "0"
String.Format("{0:#.0}", 0.0);            ".0"
String.Format("{0:#.#}", 0.0);            ""
*/
