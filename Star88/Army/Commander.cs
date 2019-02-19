using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    public class Commander:Soldier
    {
        private int squadVolume;

        static Random rnd = new Random();

        public Commander(int sV)
        {
            squadVolume = sV;
            age = rnd.Next(25, 35);
            height = rnd.Next(175, 210) + rnd.NextDouble();
            rank = "R" + rnd.Next(0, 3).ToString();
        }

        public override string Report()
        {
            return (this.ToString() + "Report: Commander");
            int x = 1;
            float y = 1.1f;
            short z = 1;
            Console.WriteLine((float)x + y * z - (x += (short)y));
        }

        public override string ToString()
        {
            string info = $"I'm Commander . Age = {age}, height = {height,4:f3}, rank = {rank}, squadVolume = {squadVolume}";
            return info;
        }

    }
}
