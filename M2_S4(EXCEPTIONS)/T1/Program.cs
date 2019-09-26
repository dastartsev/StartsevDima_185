using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Methods
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

    // Получение значения целочисленного параметра
    public static int GetIntValue(string comment)
    {
        Console.Write(comment);
        return int.Parse(Console.ReadLine());
    }

    public static void MatrPrint(int[,] ar)
    {
        // TODO: вывод в консоль двумерного массива 
        // в виде матрицы
    }

    public static int[,] UnitMatr(int n)
    {// Сформировать единичную матрицу:
        if (n <= 0)
            throw new ArgumentOutOfRangeException("Аргумент метода  должен быть положительным!");
        int[,] ar = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                ar[i, j] = (i == j ? 1 : 0);
        return ar;
    }
}


public class Program
{
    public static void Main()
    {
        int[,] res = { }; // ссылка на двумерный массив (матрица)
        int rank; // Порядок матрицы
        do
        { // цикл повторения решений
            rank = Methods.GetIntValue("Введите порядок матрицы: ");
            try
            {
                res = Methods.UnitMatr(rank);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Для завершения программы нажмите ESC");
                continue;
            }
            catch (ArgumentNullException e1) {/* TODO */}
            catch (FormatException e2) {/* TODO */}
            catch (OverflowException e3) {/* TODO */}

            Methods.MatrPrint(res);
            Console.WriteLine("Для завершения программы нажмите ESC");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    } // Main( )
}
