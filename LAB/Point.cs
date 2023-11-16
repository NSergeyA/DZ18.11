using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    internal class Point : Figure
    {
        
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y, string color, bool visible) : base(color, visible)
        {
            X = x;
            Y = y;
        }

        public override void MoveHorizontal(int distance)
        {
            X += distance;
        }

        public override void MoveVertical(int distance)
        {
            Y += distance;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine($"Координаты: ({X}, {Y})");
            
        }
    }
}
