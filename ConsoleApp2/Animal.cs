using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Animal
    {
        public abstract void animalsound();
        
        public void sleep()
        {
            Console.WriteLine("sleeping!!!!!");
        }
    }

    class Lion: Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("lion says sleeping");
        }

    }

    
}
