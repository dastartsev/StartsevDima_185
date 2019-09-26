using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle
{
    public double _r { get; set; }
    public double S { get { return Math.PI * _r * _r; } }

    public Circle():this(1)
    {

    }

    public Circle(double par)
    {
        _r = par;
    }



}


public class Complex
{
    public Complex(double d, double i)
    {
        Re = d;
        Im = i;
    }

    public double Re { get; private set; }
    public double Im { get; private set; }

    public double ABS()
    {
        return Math.Sqrt(Re * Re + Im * Im);
    }

    public double ARG()
    {
        return Math.Acos(Re / this.ABS());
    }

    public override string ToString()
    {
        return $"{this.Re} + {this.Im} * i ";
    }

    public static Complex operator +(Complex ad, Complex add)
    {
        return new Complex(ad.Re + add.Re, ad.Im + add.Im);
    }
    public static Complex operator -(Complex ad, Complex add)
    {
        return new Complex(ad.Re - add.Re, ad.Im - add.Im);
    }
    public static Complex operator *(Complex ad, Complex add)
    {
        return new Complex(ad.Re * add.Re, ad.Im * add.Im);
    }
    public static Complex operator /(Complex ad, Complex add)
    {
        return new Complex(ad.Re / add.Re, ad.Im / add.Im);
    }

    public static Complex operator +(Complex ad, int val)
    {
        return new Complex(ad.Re + val, ad.Im);
    }

}

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

    static void Main(string[] args)
    {
        do
        {
            Complex c1 = new Complex(15, 13);
            Complex c2 = new Complex(5, 7);
            Console.WriteLine(c1 + c2);
            Console.WriteLine(c2 + 1);










            /*double Rmin = DInput(), Rmax = DInput(), delta = DInput();

            Circle c = new Circle();

            for(double i = Rmin; i <= Rmax;  i += delta)
            {
                c = new Circle(i);
                Console.WriteLine($"Для радиуса r = {i}, S = {c.S}");
            }*/




        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }
}
