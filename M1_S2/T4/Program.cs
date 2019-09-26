using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = (int) 'a';
            int z = (int) 'z';
            int A = (int) 'A';
            int Z = (int) 'Z';
            int zero = (int) '0';
            int nine = (int)'9';
            string str;
            Console.WriteLine("введите символ");
            str = Console.ReadLine();
            char code;
            char.TryParse(str, out code);
            
                if (code >= 'a' && code <= 'z')
                {
                    Console.WriteLine("word");
                } else if(code >= 'A' && code <= 'Z')
                {
                    Console.WriteLine("WORD");
                }
                else if (code >= '0' && code <= '9')
                {
                    Console.WriteLine("number");
                } else
                {
                    Console.WriteLine("WTF");
                }
            Console.WriteLine(code);
            str = Console.ReadLine();
            
        }
    }
}
