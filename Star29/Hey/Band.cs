using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hey
{
    public class Band
    {
        static Random rnd = new Random();
        public Instrument[] band;
        Band()
        {
            int size = rnd.Next(5, 13);
            band = new Instrument[size];
            for (int i = 0; i < size; i++)
            {
                if (rnd.Next(1,101) > 80)
                {
                    band[i] = new Drum()
                }
            }
        }
    }
}
