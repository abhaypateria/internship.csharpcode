using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car : Vehicle
    {
       
        public int numdoor;
        public Car(string brand,double price,int numdoor) : base(brand,price)
        {
            this.numdoor = numdoor;
        }

        public void display()
        {
            Console.WriteLine("Car details ");
            Console.WriteLine("brand is " + brand);
            Console.WriteLine("price is " + price);
            Console.WriteLine("num of door" + numdoor);
        }

    }
}
