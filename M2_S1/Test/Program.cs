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
                matr[i, j] = Input();
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


        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }
}

int a = beer.man;
beer.man = 12;