using System;

class Program
{

    /*
     * 
     * Разработать метод CreateArray( ), возвращающий сформированный и заполненный массив из N целочисленных 
     * элементов  со случайными значениями из диапазона [-1;1].
     *  Разработать метод ShowArray( ) для вывода в консоль массива, ссылка на который передана в параметре.
     *  Элементы массива при выводе разделены символом пробела и выводятся на экран по десять в строке.
     */
    public static int Input()
    {
        string str;
        int ans;
        bool b;
        do
        {
            str = Console.ReadLine();
            b = !int.TryParse(str, out ans) && ans <= 0;
            if (b)
            {
                Console.Write("Повторите ввод данных");
            }
        } while (b);
        return ans;
    }

    static int[] CreateArray(Random rnd, int n)
    {
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; ++i)
        {
            arr[i] = rnd.Next(-1, 2);
        }
        return arr;
    }

    static void ShowArray(int[] arr)
    {
        int i = 0;
        for (i = 0; i + 10 < arr.Length; i += 10)
        {
            for (int j = i; j < i + 10; ++j)
            {
                Console.Write($"{arr[j]} ");
            }
            Console.WriteLine();
        }
        for (; i < arr.Length; ++i)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

    static void MergeArray(int[] a, int[] b, int[] c)
    {
        for (int i = 0; i < c.Length; ++i)
        {
            if (i % 2 == 0 && i < a.Length)
            {
                c[i] = a[i];
            }
            else if (i % 2 == 1 && i < b.Length)
            {
                c[i] = b[i];
            }
            else
            {
                c[i] = 0;
            }
        }
    }

    static void Main(string[] args)
    {
        do
        {
            Random rnd = new Random();
            int K, N;
            Console.Write("Введите размер первого массива: ");
            K = Input();
            Console.Write("Введите размер второго массива: ");
            N = Input();

            int[] A = new int[K], B = new int[N], C = new int[Math.Max(K, N)];
            A = CreateArray(rnd, K);
            B = CreateArray(rnd, N);
            MergeArray(A, B, C);

            Console.WriteLine("Первый массив:");
            ShowArray(A);
            Console.WriteLine("Второй массив:");
            ShowArray(B);
            Console.WriteLine("Merge массив:");
            ShowArray(C);


        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }
}
