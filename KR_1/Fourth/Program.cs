using System;

class Program
{
    public static int Input()
    {
        int a;

        while (!int.TryParse(Console.ReadLine(), out a) && a < 0)
        {
            Console.WriteLine("Неверный ввод, повторите попытку: ");
        }

        return a;
    }


    static void SummCalculate(out double S1, out double S2, int N)
    {
        double temp;
        S1 = 1;
        S2 = 0;
        double[] r = new double[N + 1];
        r[0] = 1;

        for (int i = 1; i < r.Length; ++i)
        {
            temp = 0;
            for (int k = 1; k < r.Length; ++k)
            {
                temp =(double) Factorial(N) / (Factorial(k + 1) * Factorial(N - k)) * r[N-k];
            }
            r[i] = (double)-1 / (N + 1) * temp;
            if (i % 2 == 0)
            {
                S1 += r[i];
            } else
            {
                S2 += r[i];
            }
        }
    }

    static double Factorial(int temp)
    {
        return (temp > 1) ? temp - 1 : 1;
    }

    static void Print(int a, double b, double c)
    {
        Console.WriteLine("{0}: S1={1:f3}, S2={2:f3}", a, b, c);
    }

    static void Main(string[] args)
    {
        do
        {
            Console.Write("Введите N: ");
            int N = Input();
            double S1, S2;
            for (int i = 1; i < N; ++i)
            {
                SummCalculate(out S1, out S2, i);
                Print(i, S1, S2);
            }

        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }

}
