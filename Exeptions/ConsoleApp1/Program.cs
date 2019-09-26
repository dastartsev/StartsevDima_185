using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

class Program
{
    


    
    static void Main()
    {
        Test t = new Test();
        MyDel del = Test.Test_M;


        for (int i = 0;i < 10; ++i)
        {
            Console.WriteLine(del(10.1 + i, 20.2 + i));
        }
       
        int a = Console.Read();
    }

}
    

