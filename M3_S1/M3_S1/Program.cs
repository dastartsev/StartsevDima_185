using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public delegate int[] Row(int num); // делегат-тип 
    public delegate void Print(int[] ar); // делегат-тип


    // Метод возвращает массив цифр целого числа-параметра. 
    static public int[] GetFib(int num)
    {
        int[] fib = new int[num + 1];
        fib[0] = fib[1] = 1;
        for (int i = 2; i < num + 1; ++i)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        return fib;
    }
    // Вывод значений элементов массива-параметра. 
    static public void Display(int[] ar)
    {
        for (int i = 0; i < ar.Length; i++)
            Console.Write("{0}\t", ar[i]);
        Console.WriteLine();
    }
    static public void DisplaySum(int[] ar) {
        int sum = 0;
        for (int i = 0; i < ar.Length; i++)
            sum += ar[i];
        Console.WriteLine(sum);
    }


    static void Main(string[] args)
    {
        Row row = new Row(GetFib);
        Print print = new Print(Display);
        print += DisplaySum;
        int n = 5;
        print(row(5));
        Console.Read();
    }
}