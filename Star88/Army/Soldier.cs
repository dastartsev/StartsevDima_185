using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    public abstract class Soldier
    {
        public int age;
        public double height;
        public string rank;

        public Soldier()
        {

        }


        public Soldier(int age, double height, string rank)
        {
            this.age = age;
            this.height = height;
            this.rank = rank;
        }

        public abstract string Report();

        public override string ToString()
        {
            string info = $"Age = {age}, height = {height,4:f3}, rank = {rank} ";
            return info;
        }
    }
}
