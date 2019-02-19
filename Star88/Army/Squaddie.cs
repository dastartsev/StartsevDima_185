using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    public class Squaddie : Soldier
    {
        static Random rnd = new Random();

        public Squaddie(int age, double height, string rank) : base(age, height, rank)
        {

        }

        public Squaddie()
        {
            age = rnd.Next(18, 27);
            height = rnd.Next(165, 200) + rnd.NextDouble();
            rank = "S" + rnd.Next(0, 2).ToString();
        }

        public override string Report()
        {
            return(this.ToString() + "Report: Squaddie");
        }

        public override string ToString()
        {
            string info = $"I'm Squaddie. Age = {age}, height = {height,4:f3}, rank = {rank}";
            return info;
        }

    }
}
