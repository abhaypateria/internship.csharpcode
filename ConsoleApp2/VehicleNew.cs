using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class VehicleNew
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting");
        }
    }

    // CHILD CLASS 1
    class CarNew : VehicleNew
    {
        public override void Start()
        {
            Console.WriteLine("Car starts with key");
        }
    }

    // CHILD CLASS 2
    class Bike : VehicleNew
    {
        public override void Start()
        {
            Console.WriteLine("Bike starts with kick");
        }
    }

}
