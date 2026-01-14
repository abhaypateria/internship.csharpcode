using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
      public class Rectangle

        {
            public double Length;
            public double Width;

            public Rectangle(double length, double width)
            {
                this.Length = length;
                this.Width = width;
            }
            public double CalculateArea()
            {
                return Length * Width;
            }
        }
    



}
