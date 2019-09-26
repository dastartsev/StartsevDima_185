using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_LIB;


class Program
{
    public static double Input()
    {
        double temp;

        while (!double.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("Incorrect input, try again");
        }
        return temp;
    }


    static void Main(string[] args)
    {
        Random rnd = new Random();


    }
}