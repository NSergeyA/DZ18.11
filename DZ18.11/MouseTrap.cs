using System;

namespace DZ18._11
{
    internal class MouseTrap : IGameDecorator
    {
        public void Play()
        {
            Console.WriteLine("Игра в мышеловке");
        }
    }
}
