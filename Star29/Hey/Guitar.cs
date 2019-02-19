using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hey
{
    public class Guitar:Instrument
    {
        Guitar(int mastery)
        {
            this.mastery = mastery;
            volume = rnd.Next(4, 8) + rnd.NextDouble();
        }

        public override string Play()
        {
            return $"Broohhhhm {volume,4:f3}";
        }

        public override string ToString()
        {
            string info = $"Volume is {volume} and mastery is {mastery}";
            return info;
        }
    }
}
