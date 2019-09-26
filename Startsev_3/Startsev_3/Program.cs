using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
    Старцев Дмитрий Алексеевич БПИ185 Вариант 3
    */
class Monomial// реализуем класс где а -коф , а n- степень
{
    public double a;
    public int n;
    public override string ToString()
    {
        return $"{a} * x ^ {n}";
    }
}

class Program
{
    public static double Input()// ввод числа
    {
        double a;

        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Неверный ввод");
        }

        return a;
    }

    delegate double Del(Monomial m, double x1);
    static void Main(string[] args)
    {
        do
        {
            Random rnd = new Random();
            Monomial[] arr = new Monomial[8];
            for (int i = 0; i < arr.Length; i++)// случайные числа
            {
                
                arr[i] = new Monomial();
                arr[i].a = rnd.NextDouble() * 40 - 20;
                arr[i].n = rnd.Next(1, 9);
            }
            Del d = (Monomial m, double x1) => m.a * (Math.Pow(x1, m.n));// делегат
            Console.WriteLine("Введите x: ");
            double x = Input();
            double sum = 0; ;
            for (int i = 0; i < 8; i++)// вывод многочлена 
            {
                if (i != arr.Length - 1)
                {
                    Console.Write($"{arr[i]} +  ");
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
                sum += d(arr[i], x);
            }
            Console.WriteLine();
            Console.WriteLine(sum);

        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }
}

