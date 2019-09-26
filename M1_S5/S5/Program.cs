using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
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

    public static double DInput()
    {
        double temp;

        while (!double.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Incorrect input, try again");
        }
        return temp;
    }

    public static void T1()
    {
        Random rnd = new Random();
        int asize = Input(), bsize = Input();
        int[] a = new int[asize];
        int[] b = new int[bsize];

        for (int i = 0; i < a.Length; ++i)
            a[i] = rnd.Next(10, 51);
         



        for (int i = 0; i < b.Length; ++i)
            b[i] = rnd.Next(10, 51);


        Print(a);
        Print(b);

        for (int i = 0; i < b.Length; ++i)
        {
            if (b[i] % 2 == 0)
                Push_Back(ref a, b[i]);
        }
        Print(a);
    }

    public static void T2()
    {
        Random rnd = new Random();
        int k = Input();
        char[] ar = new char[k];
        int a = (int)'A';
        int z = (int)'Z';
        for (int i = 0; i < k; ++i)
        {
           
            ar[i] =(char) rnd.Next(a, z + 1);
            Console.Write(ar[i]  + " ");
        }
        
    }

    public static void DZ1()
    {
        int n = Input();
        int[] ar = new int[n];
        Adding(ref ar);
        Print(ar);
    }

    public static void DZ4()
    {
        int n = Input();
        int[] ar = new int[n];
        FIB(ref ar);
        Rev_Print(ar);
    }

    public static void FIB(ref int[] ar)
    {
        ar[0] = 0;
        ar[1] = 1;
        for (int i = 2; i < ar.Length; ++i)
        {
            ar[i] = ar[i - 1] + ar[i - 2];
        }
    }
    public static void Adding(ref int[] ar)
    {
        Random rnd = new Random();
        for (int i = 0; i < ar.Length; ++i)
        {
            ar[i] = rnd.Next(0, 10001) * 2 + 1;
        }
    }

    public static void Push_Back(ref int[] ar, int elem)
    {
        Array.Resize(ref ar, ar.Length + 1);
        ar[ar.Length - 1] = elem;
    }

    public static void Print(int[] ar)
    {
        for (int i = 0; i < ar.Length; ++i)
            Console.Write(ar[i] + " ");
        Console.WriteLine();
    }

    public static void Rev_Print(int[] ar)
    {
        for (int i = ar.Length - 1; i >= 0; --i)
            Console.Write(ar[i] + " ");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        do
        {
            DZ4();

        } while (Console.ReadKey(true).Key == ConsoleKey.Enter);
    }
}
