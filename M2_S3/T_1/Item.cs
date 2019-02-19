using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_1
{
    public class Item
    {
        public Item(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string GetInfo()
        {
            return $"{Name,-10}{Price,7}{Quantity,7}{Price * Quantity, 7}";
        }
        public string Name { get; }

        public int Price { get; }

        public int Quantity { get; }

        public override string ToString()
        {
            return $"{Name,-10}{Price,7}{Quantity,7}{Price * Quantity,7}";
        }
    }

   

}