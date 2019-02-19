using System;
using T_1_lib_;


namespace T_1
{
    class Program
    {
        static void Main(string[] args)
        {
            A[] arr = new A[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; ++i)
            {
                if (rnd.Next(2) % 2 == 0)
                {
                    arr[i] = new A();
                }
                else
                {
                    arr[i] = new B();
                }
            }
            foreach (A d in arr)
                d.get_A();
            Console.WriteLine();

            Console.WriteLine("\nClass B: ");
            foreach (A d in arr)
                if (d is B) d.get_A();
            Console.WriteLine();

            Console.WriteLine("\nClass A: ");
            foreach (A d in arr)
                if (!(d is B)) d.get_A();
            Console.WriteLine();
            int a = Console.Read();
        }
    }
}
