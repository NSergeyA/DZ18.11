using System;

namespace DZ18._11
{
    internal class Slide : IGameDecorator
    {
        public void Play()
        {
            Console.WriteLine("Игра на горке");
        }
    }
}
