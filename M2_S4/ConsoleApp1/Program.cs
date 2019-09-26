using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("KEK");
        Cow c = new Cow(40, "Мурка");
        Dog d = new Dog("Котопёс", "Ебливый", true);

        Console.WriteLine(c.AnimalSound() + " " + c.AnimalInfo());
        Console.WriteLine(d.AnimalSound() + " " + d.AnimalInfo());
        int i = Console.Read();
    }
}
