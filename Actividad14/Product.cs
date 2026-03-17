using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double TotalValue(int quantity)
        {
            return price * quantity;
        }

        public void Stock()
        {
            if (quantity == 0)
            {
                Console.WriteLine("Sin existencias.");
            }
            else if (quantity > 0 && quantity < 10)
            {
                Console.WriteLine("Stock bajo.");
            }
            else
            {
                Console.WriteLine("Stock suficiente.");
            }
        }
    }
}