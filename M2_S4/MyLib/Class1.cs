using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLib
{
   public abstract class Animal
    {
        public string name { get; set; }

        public abstract string AnimalSound();
        public abstract string AnimalInfo();

        public Animal(string sname)
        {
            this.name = sname;
        }
    }


    public class Dog:Animal
    {
        public string poroda { get; set; }
        public bool IsTrained { get; set; }

        public Dog(string name, string poroda, bool IsTrained): base(name)
        {
            this.poroda = poroda;
            this.IsTrained = IsTrained;
        }

        public override string AnimalInfo()
        {
            return $" Name is {name}, poroda is {poroda}";
        }

        public override string AnimalSound()
        {
            return "GAV";
        }
    }

    public class Cow:Animal
    {
        public int MpD { get; set; }

        public Cow(int mpD, string name):base(name)
        {
            MpD = mpD;
        }

        public override string AnimalInfo()
        {
            return $"MpD is {MpD},  name is {name}";
        }

        public override string AnimalSound()
        {
            return "Miy";
        }
    }
}
