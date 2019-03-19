using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dot
{
    public double x, y;

    public Dot(double xx, double yy)
    {
        x = xx;
        y = yy;
    }
    
}

class Vector
{
    public Dot d1, d2;

    public Vector(double x, double y, double x1, double y1)
    {
        this.d1 = new Dot(x, y);
        this.d2 = new Dot(x1, y1);
    }

    public double Mod()
    {
        return Math.Sqrt(Math.Pow(d2.x - d1.x, 2) + Math.Pow(d2.y - d1.y, 2));
    }

}
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

    struct MyStruct
    {
        int x;
    }
    static void Main(string[] args)
    {
        MyStruct s = new MyStruct();
        Console.WriteLine(s.ToString());
        int a = Console.Read();
    }
}

