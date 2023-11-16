using System;

namespace DZ18._11
{
    internal class Beach : IGameDecorator
    {
        public void Play()
        {
            Console.WriteLine("Игра на пляже");
        }
    }
}
