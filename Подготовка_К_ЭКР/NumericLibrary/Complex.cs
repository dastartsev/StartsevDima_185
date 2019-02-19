using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLibrary
{
    class Complex:Pair
    {
        /// <summary>
        /// чё бормочешь когда дрочешь
        /// </summary>
        /// <param name="x">координаты икс</param>
        /// <param name="y"> координаты y</param>
        public Complex(int x, int y):base(x,y)
        {
            
        }
        public override Pair Add(Pair b)
        {
            return new Complex(X + b.X, Y + b.Y);
        }
            


        public override Pair Mult(Pair b)
        {
            return new Complex((X * b.X) - (Y * b.Y), (X * b.Y) + (Y * b.X));
        }

        public override Pair Sub(Pair b)
        {
            return new Complex(X - b.X, Y - b.Y);
        }
    }
}
