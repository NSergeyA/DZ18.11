using System;

namespace DZ18._11
{
    internal class Fishing : IGameDecorator
    {
        public void Play()
        {
            Console.WriteLine("Игра в рыбалку");
        }
    }
}
