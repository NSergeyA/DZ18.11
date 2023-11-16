using System;

namespace DZ18._11
{
    enum Country { Франция, Китай, Россия, Казахстан }
    internal class Player : Person
    {
        private Country country;
        public Player(string name, Country country) : base(name)
        {
            this.country = country;
        }
        public override void Print()
        {
            Console.WriteLine($"Страна: {country}\nИмя: {name}");
        }
    }
}
