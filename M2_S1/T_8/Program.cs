using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    public static Random rnd = new Random();

    public static int Input()
    {
        int temp;

        while (!int.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Incorrect input, try again");
        }
        return temp;
    }

    public static double DInput()
    {
        double temp;

        while (!double.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Incorrect input, try again");
        }
        return temp;
    }

    public static int[,] Create(int n, int m)
    {
        
        int[,] ar = new int[m, n];

        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                ar[i, j] = rnd.Next(1, 11);
            }
        }
        return ar;
    }

    public static int[,] Mult (int[,] A, int[,] B)
    {
        if (A.GetLength(1) != B.GetLength(0))
            return null;
        else
        {
            int k = A.GetLength(0) , l = B.GetLength(1);
            int[,] ar = new int[k, l];
            for (int i = 0; i < k; ++i)
            {
                for (int j = 0; j < l; ++j)
                {
                    for (int temp = 0; temp < A.GetLength(1); ++temp)
                        ar[i, j] += A[i, temp] * B[temp, j];
                }
            }
            return ar;
        }
    }

    public static string Print (int[,] ar)
    {
        string str = "";
        for (int i = 0; i < ar.GetLength(0); ++i)
        {
            for (int j = 0; j < ar.GetLength(1); ++j)
            {
                str = str + ar[i, j] + "\t";
            }
            str += "\n";
        }
        str += "\n";
        Console.WriteLine(str);
        return str;
    }


    static void Main(string[] args)
    {
        int n, m;
        int[,] A = Create(3, 2), B = Create(2, 3);
        Print(A);
        Print(B);
        Print(Mult(A, B));

        n = Input();
    }
}
