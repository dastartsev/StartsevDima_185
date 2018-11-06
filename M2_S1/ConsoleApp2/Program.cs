using System;

// Определить массив массивов для представления треугольника Паскаля.
// 0-й элемент - массив из одного элемента со значением С(0,0)=1, 
// 1-й элемент - массив из 2-х элементов С(1,0)=С(1,1)=1.
// 2-й элемент - массив из 3-х элементов С(2,0)=С(2,2)=1, С(2,1)=2...
// n-й элемент - массив из n+1 элементов: С(n,0)=С(n,n)=1, 
//   С(n,k)=C(n-1,k-1)+C(n-1,k). 
// Вводя неотрицательные значение n, построить массив-массивов  
// со значениями биномиальных коэффициентов и вывести его на экран 
// с помощью циклов foreach, размещая значения элементов каждого
// массива нижнего уровня по на отдельной строке...

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

    public static void Input_M(int[][] matr)
    {
        for (int i = 1; i < matr.GetLength(0); i++)
            for (int j = 0; j < i + 1; j++)
            {
                if (j != 0 && j != i)
                {
                    matr[i][j] = matr[i - 1][j] + matr[i - 1][j - 1];
                } else if (j == 0)
                {
                    matr[i][j] = matr[i - 1][j];
                } else
                {
                    matr[i][j] = matr[i - 1][j - 1];
                }
                
            }
    }

    public static void Output_M(int[][] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++, Console.WriteLine())
            for (int j = 0; j < i + 1; j++)
            Console.Write("{0,3}", matr[i][j]);
    }

    static void Main(string[] args)
    {
        do
        {
            Console.Write("Введите количество строк трейгольника Паскаля:");
            int n = Input();
            int[][] ar = new int [n][];
            for (int i = 0; i < ar.GetLength(0); ++i)
            {
                ar[i] = new int[i + 1];
            }
            ar[0][0] = 1;
            Input_M(ar);
            Output_M(ar);

        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }
}
