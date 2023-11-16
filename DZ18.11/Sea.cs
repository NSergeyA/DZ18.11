using System;

namespace DZ18._11
{
    internal class Sea : IGameDecorator
    {
        public void Play()
        {
            Console.WriteLine("Игра в море");
        }
    }
}
