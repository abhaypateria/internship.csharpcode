using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   internal class Program
    {
        public int add(int x, int y)
        {
            return x + y;

        }
        public int add(int x, int y,int z)
        {
            return x + y + z;

        }
        static void Main(string[] args)
        {
            //static polymorphism using add function
            Program pg=new Program();

            Console.WriteLine(pg.add(1, 2));
            Console.WriteLine(pg.add(2, 3, 5));

            //run time polymorphism using VehicleNew class
            VehicleNew ve=new VehicleNew();
            ve.Start();

            VehicleNew car=new CarNew();
            car.Start();
            VehicleNew bike = new Bike();
            bike.Start();


        //encapsulation using rectangle class
            Console.WriteLine("enter length");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter width");
            double w= Convert.ToDouble(Console.ReadLine());

            Rectangle r = new Rectangle(l, w);

            double area=r.CalculateArea();
            Console.WriteLine(area);


            // inheritance using vehicle & car class
            Console.WriteLine("enter vehicle brand ");
            string brand= Console.ReadLine();

            Console.WriteLine("enter price ");
            double price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter num of door");
            int numdoor = Convert.ToInt16(Console.ReadLine());

            Car v = new Car(brand, price, numdoor);
            v.display();

            //abstraction using abstract Animal class and lion class

            Lion lion = new Lion();
            lion.sleep();
            lion.animalsound();


            //data variables practice
            int a= 5;
            float b = 5.5f;
            double c= 5.55555d;
            char d = 'A';
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("enter input ");


            string input = Console.ReadLine();
            string number = Console.ReadLine();
            Console.WriteLine(input+(Convert.ToInt32(number)+6));


            int e= Math.Min(34, 234);
            int f = Math.Abs(-25);
            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.WriteLine("enter name");
            string name= Console.ReadLine();
            Console.WriteLine("enter time in hours");
            string time= Console.ReadLine();
            Console.WriteLine($"you are {name}. you will work for {time}. hours");


            Console.WriteLine(input);
            Console.WriteLine("Hello world, first c# programm on visual studio");
            Console.ReadKey();
        }
    }
}
