using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_1
{
    class ShopppingCart
    {
        private int _capticity;
        private int _totalItem;
        private int _totalPrice;
        public Item[] _cart;

        public ShopppingCart(int capacity)
        {
            _capticity = capacity;
            _cart = new Item[capacity];
        }

        public ShopppingCart() : this(10)
        {

        }

        private void IncreaseSize()
        {
            Item[] temp = new Item[_capticity + 3];
            for (int i = 0; i < _capticity; ++i)
            {
                temp[i] = _cart[i];
            }
            _cart = temp;
            _capticity += 3;
        }

        public void AddToCart(Item item)
        {
            if (_totalItem == _capticity)
            {
                IncreaseSize();
            }
            _cart[_totalItem] = item;
            ++_totalItem;
            _totalPrice += item.Price * item.Quantity;
        }

        public override string ToString()
        {
            string res = "\nShopping Cart\n";
            for (int i = 0; i < _totalItem; ++i)
            {
                res += _cart[i] + "\n";
            }
            res += $"Total: {_totalPrice}";
            return res;
        }
    }
}
