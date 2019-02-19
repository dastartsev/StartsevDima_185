using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLibrary
{
    abstract class Pair
    {
        private int x;

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get;
        }


        public Pair(int x, int y)
        {
            this.x = x;
            Y = y;
        }

        public abstract Pair Add(Pair b);
        public abstract Pair Sub(Pair b);
        public abstract Pair Mult(Pair b);

        public int PairEqual(Pair b)
        {
            return (X == b.X && Y == b.Y) ? 0 : (X + Y > b.X + b.Y) ? -1 : 1;
        }

        public override string ToString()//спросить про виртуал
        {
            return $"X = {X}, Y = {Y}";
        }

    }
}
