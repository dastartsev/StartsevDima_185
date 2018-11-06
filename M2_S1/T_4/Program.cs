using System;

// Ввести положительные значения N и M. Построить двумерный 
// целочисленный массив (матрицу) с размерами N на M, элементы 
// которого a[i, j] = (i+1)*(2*j+1), для i от 0 до (N-1), 
// j от 0 до (M-1). 
// Вывести матрицу в виде таблицы, а также значения свойств 
// Rank и Length. 


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
                matr[i, j] = (i + 1) * (2 * j + 1);
    }

    public static void Output_M(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++, Console.WriteLine())
            for (int j = 0; j < matr.GetLength(1); j++)
                Console.Write("{0,3}", matr[i, j]);
    }

    public static bool Is_Sq(int [,] matr)
    {
        if (matr.GetLength(0) == matr.GetLength(1))
        {
            for (int i = 0; i < matr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < matr.GetLength(1); j++)
                    if (i + j >= matr.GetLength(0))
                        matr[i, j] = 0;

            return true;
        } else
        {
            return false;
        }
    }


    static void Main(string[] args)
    {
        do
        {

            int n, m;
            Console.Write("Введите число строк: ");
            n = Input();
            Console.Write("Введите число столбцов: ");
            m = Input();
            int[,] ar = new int [n,m];
            Input_M(ar);
            Output_M(ar);
            Console.WriteLine($"Rank = {ar.Rank}");
            Console.WriteLine($"Length = {ar.Length}");
            Is_Sq(ar);
            Output_M(ar);
        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);

    }
}