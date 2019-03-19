using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point
{
    public double x { get; set; }
    public double y { get; set; }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double Distance(Point p)
    {
        return Math.Pow((p.x - this.x), 2) - Math.Pow((p.y - this.y), 2);
    }
}

public class Circle
{
    public double rad { get; set; }
    public Point Point_Center;
    public Circle(double x, double y, double rad)
    {
        Point_Center = new Point(x, y);
        this.rad = rad;
    }

    public override string ToString()
    {
        return $"Радиус = {rad:f3}. Координаты центра  {Point_Center.x:f3}, {Point_Center.y:f3}";
    }
}

class Program
{
    public static double Input()
    {
        double a;

        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Неверный ввод, введите вещественное число");
        }

        return a;
    }

    static void Main(string[] args)
    {
        do
        {
            List<Circle> kek = new List<Circle>();
            double x, y, rad;

            for (int i = 0; i < 4; i++)
            {
                x = Input(); y = Input(); rad = Input();
                kek.Add(new Circle(x, y, rad));
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(kek[i]);
            }
            kek.Sort((a,b)=> (a.Point_Center.Distance(new Point(0, 0)) * a.rad)
                  .CompareTo((b.Point_Center.Distance(new Point(0, 0)) * b.rad)));

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(kek[i]);
            }

        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
    }
}

