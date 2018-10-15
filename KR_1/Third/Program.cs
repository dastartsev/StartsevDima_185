using System;

class Program
{
    public static int Input()
    {
        int a;

        while (!int.TryParse(Console.ReadLine(), out a) && a < 1)
        {
            Console.WriteLine("Неверный ввод, повторите попытку: ");
        }

        return a;
    }

    static double[] CreateArray(int N)
    {
        double[] arr = new double[N];
        for (int i = 0; i < N; ++i)
        {
            arr[i] = (double)Math.Pow(-1, i + 1) / (1 + i * 2);
        }
        return arr;
    }

    static void ShowArray(double[] arr)
    {
        for (int i = 0; i < arr.Length; ++i)
        {
            Console.Write("{0:f4} ", arr[i]);
            if ((i + 1) % 8 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

    static void ShiftArray(double[] arr)
    {
        int it = arr.Length - 1;
        for (int i = arr.Length - 1; i >= 0; --i)
        {
            if (arr[i] >= 0)
            {
                arr[it] = arr[i];
                --it;
            }
        }
        for (; it >= 0; --it)
        {
            arr[it] = 0;
        }
    }

    static void Main(string[] args)
    {
        do
        {
            Console.Write("Введите число K: ");
            int K = Input();
            double[] A = new double[K];
            A = CreateArray(K);
            Console.WriteLine("Массив А до:");
            ShowArray(A);

            ShiftArray(A);
            Console.WriteLine("Массив А после:");
            ShowArray(A);


        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }

}