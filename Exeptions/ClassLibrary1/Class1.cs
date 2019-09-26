using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class QT
    {
        public QT(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        double Solve(double x)
        {
            double ans = A * x * x + B * x + C;
            if (ans == 0)
            {
                throw new DivZero("kEk");
            }
            return A * x * x + B * x + C;
        }

        public double Del(QT other, double x)
        {
            double ans = 0;
            try
            {
                ans = this.Solve(x) / other.Solve(x);
            }
            catch (DivZero ex)
            {
                Console.WriteLine(ex.Message);
                ans = 0;
            }
            return ans;
        }
    }

    public class DivZero : DivideByZeroException
    {
        public DivZero(string s) : base(s)
        {

        }
    }





    public delegate int MyDel(double a, double b);

    public class Test {
        public static int Test_M(double a, double b) {
            return (int)a + (int)b;
        }
    }

}
