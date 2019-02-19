using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate string ConverRule(string str);

class Converter
{
    public string Convert(string str, ConverRule cr)
    {
        return cr(str);
    }
}




class Program
{
    public static string RemoveDigits(string str)
    {
        string new_str = "";
        for (int i = 0; i < str.Length; ++i)
        {
            if (!(str[i] > '0' && str[i] < '9'))
                new_str += str[i];
        }
        return new_str;
    }

    public static string RemoveSpaces(string str)
    {
        string new_str = "";
        for (int i = 0; i < str.Length; ++i)
        {
            if (!(str[i] == ' '))
                new_str += str[i];
        }
        return new_str;
    }

    static void Main(string[] args)
    {
        string[] ar = new string[3];
        Converter c = new Converter();
        ar[0] = "aaa";ar[1] = "b12 b";ar[2] = "l 32 p1 ";
        ConverRule deleg = new ConverRule(RemoveDigits);
        deleg += RemoveSpaces;
        deleg += RemoveDigits;
        for (int i = 0; i < 3; ++i)
            Console.WriteLine(c.Convert(ar[i],deleg));
        string a;
        string b = "3";
        a =Console.ReadLine();
        int SortedDictionary = 123;

    }
}

