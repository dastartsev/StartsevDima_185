using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class A
    {
        public void Print1(double a)
        {
            Console.Write("A");
        }
        
    }
    public class B : A
    {
        public void Print1(int a)
        {
            Console.Write("B");
        }
    }
    

   
    class Program
    {

        static void Main(string[] args)
        {

            checked
            {
                byte b = 100;
                byte a = (byte)(b)* 10;
                
            }
            Console.Read();
        }

        private void Print(int a)
        {
            try
            {
                int c = 5 / a;
            }
            catch (Exception)
            {
                Console.Write(2);
                return;
            } finally
            {
                Console.WriteLine(5);
            }
            
            
        }
    }
}
