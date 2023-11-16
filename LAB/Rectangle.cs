using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Rectangle : Point
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height, string color, bool visible): base(x, y, color, visible)
        {
            Width = width;
            Height = height;
        }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
