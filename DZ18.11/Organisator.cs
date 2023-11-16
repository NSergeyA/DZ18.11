using System;

namespace DZ18._11
{
    internal class Organisator : Person
    {
        public Organisator(string name) : base(name) { }
        public override void Print()
        {
            Console.WriteLine($"Организатор: {name}");
        }

    }
}
