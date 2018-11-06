using System;


class Program
{

    public static int Input()
    {
        int a;

        while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
        {
            Console.WriteLine("Неверный ввод, введите целое число большее 0");
        }

        return a;
    }

    public static void Input_M(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
            for (int j = 0; j < matr.GetLength(1); j++)
                matr[i, j] = (i + j) % matr.GetLength(0) + 1;
    }

    public static void Output_M(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++, Console.WriteLine())
            for (int j = 0; j < matr.GetLength(1); j++)
                Console.Write("{0,3}", matr[i, j]);
    }

    static void Main(string[] args)
    {
        do
        {
            int n = Input();
            int[,] matr = new int[n, n];
            Input_M(matr);
            Output_M(matr);

        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }
}