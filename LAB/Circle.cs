using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Circle : Point
    {
            
        public double Radius { get; set; }

        public Circle(int x, int y, double radius, string color, bool visible): base(x, y, color, visible)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

