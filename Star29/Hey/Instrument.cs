using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hey
{
    public abstract class Instrument
    {
        protected static Random rnd = new Random();
        protected double volume;
        protected int mastery;

        public double V
        {
            get { return volume; }
        }

        public int M
        {
            get { return mastery; }
        }

        public abstract string Play();

    }
}
