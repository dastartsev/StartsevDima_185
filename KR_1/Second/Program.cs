using System;

class Program
{
    public static int Input_int()
    {
        int a;

        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Неверный ввод, повторите попытку: ");
        }

        return a;
    }
    public static double Input_double()
    {
        double a;

        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Неверный ввод, повторите попытку: ");
        }

        return a;
    }

    static bool Summ(double x, int K)
    {
        double eps = double.Epsilon, ans = 0;
        int n = 0;

        if (Math.Abs(x) < 7)
        {
            double temp;
            do
            {
                temp = (double)(n * n * Math.Pow(x, n)) / (Math.Pow(7, n) * (n + 1));
                ans += temp;
                ++n;
            } while (temp > eps);

            return true;
        }
        else
        {
            for (; n < K; ++n)
                ans += (double)(n * n * Math.Pow(x, n)) / (Math.Pow(7, n) * (n + 1));

            return false;
        }

    }

    static void Print(double a, double b)
    {
        Console.WriteLine("Summ({0:f4}) = {1:f4}", a, b);
    }
    static void Main(string[] args)
    {
        do
        {
            double a = Input_double(), b = Input_double();
            Print(a, b);

        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }
}