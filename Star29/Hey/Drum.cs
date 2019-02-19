using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hey
{

    public class Drum:Instrument   
    {
        Drum(int mastery)
        {
            this.mastery = mastery;
            volume = rnd.Next(8, 10) + rnd.NextDouble();
        }

        public override string Play()
        {
            return $"Booom {volume,4:f3}";
        }

        public override string ToString()
        {
            string info = $"Volume is {volume} and matery is {mastery}";
            return info;
        }
    }
}
