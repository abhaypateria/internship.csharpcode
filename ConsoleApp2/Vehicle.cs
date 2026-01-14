using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Vehicle
    {
        public string brand;
        public double price;
        public Vehicle(string brand, double price)
        {
            this.brand = brand;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("brand is " + brand);
            Console.WriteLine("price is " + price);
        }
    }
}
