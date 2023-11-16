using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{

    internal abstract class Figure
    {
        public string Color { get; set; }
        public bool Visible { get; set; }
        public Figure(string color, bool visible)
        {
            Color = color;
            Visible = visible;

        }
    
        public abstract void MoveHorizontal(int distance);
        public abstract void MoveVertical(int distance);
        public void ChangeColor(string color)
        {
            Color = color;
        }
        public string GetVisibility()
        {
            return Visible ? "Видимая" : "Невидимая";
        }
        public void Display()
        {
            Console.WriteLine($"Цвет: {Color}\nВидимость: {GetVisibility()}");

        }
    }

}
