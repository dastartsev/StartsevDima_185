using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ShopppingCart sc = new ShopppingCart();
                Item item = new Item("Orangee", 15, 10);
                Item item0 = new Item("Milk", 2, 40);
                sc.AddToCart(item);
                sc.AddToCart(item0);
                Console.WriteLine(sc);
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }
    }
}
