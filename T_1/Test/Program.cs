using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    public double x = 0, y = 0;

    public override string ToString()
    {
        return $"x: {x}  y: {y}";
    }
}
class Program
{
    delegate double Deleg(Point a, Point b);
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Point[] arr = new Point[15];
        Deleg d = (Point p1, Point p2) => Math.Sqrt((p1.x * p1.x - p2.x * p2.x) + (p1.y * p1.y - p2.y * p2.y));
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Point();
            arr[i].x = rnd.NextDouble() * 20 - 10;
            arr[i].y = rnd.NextDouble() * 20 - 10;
        }
        int n1 = 1, n2 = 2;
        double dist = d(arr[1], arr[2]);
        for (int i = 0; i < 15; i++)
        {
            for (int j = i + 1; j < 15; j++)
            {
                if (dist > d(arr[i], arr[j])) {
                    dist = d(arr[i], arr[j]);
                    n1 = i + 1;
                    n2 = j + 1;
                }
            }

        }

        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine(dist);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.Read();
    }
}
