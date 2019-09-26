using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public class Item
    {
        public Item(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public string name { get; set; }
        public double price { get; set; }
        public int amount { get; set; }

        public override string ToString()
        {
            return $"{name}\t\t{price:C}\t\t{amount}\t\t{price * amount:C}";
        }
    }

    public class ShoppingCart
    {
        private int _itemCount; // количество предметов в корзине
        private double _totalPrice; // цена всех предметов в корзине
        private int _capacity; // текущая вместимость корзины
        public Item[] cart;
        
        public ShoppingCart()
        {
            _capacity = 5;
            _itemCount = 0;
            _totalPrice = 0.0;
            cart = new Item[_capacity];
        }
        
        public void AddToCart(string itemName, double price, int quantity) {
            if (_itemCount == _capacity)
            {
                IncreaseSize();
            } else
            {
                cart[_itemCount] = new Item(itemName, price, quantity);
                _totalPrice += price;
                _itemCount++;
            }
        }
        /// <summary>
        /// Увеличивает вместимость корзины на 3
        /// </summary>
        private void IncreaseSize() {
            Array.Resize(ref cart, cart.Length + 3);
            _capacity += 3;
        }
        /// <summary>
        /// Возвращает предметы в корзине с дополнительной информацией
        /// </summary>
        public override string ToString()
        {
            return ("I");
        }
    }

    public class GP
    {
        public double _start { get; set; }
        public double _increment { get; set; }
        public GP()
        {
            _start = 0;
            _increment = 1;
        }

        public GP(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }

        double this[int index]
        {
            get
            {
                return _start * Math.Pow(_increment, index);
            }
        }

        public double GetSum(int n)
        {
            double ans = _start;
            for (int i = 1; i < n; ++i)
            {
                ans += _start * Math.Pow(_increment, i);
            }
            return ans;
        }

        public override string ToString()
        {
            return ($"{_start:F4} - begining, {_increment:F4} - increment");
        }
    }




    static void Main(string[] args)
    {
        Random rnd = new Random();
        int n = rnd.Next(5, 16);
        GP obj;
        GP[] ar = new GP[n];

        for (int i = 0; i < n; ++i)
        {
            ar[i] = new GP(rnd.Next(0, 10) + rnd.NextDouble(), rnd.Next(0, 5) + rnd.NextDouble());
        }

        for (int i = 0; i < n; ++i)
        {
            Console.WriteLine(ar[i] + $", sum of 5 = {ar[i].GetSum(5):F4}");
        }
        int R = Console.Read();
    }
}
