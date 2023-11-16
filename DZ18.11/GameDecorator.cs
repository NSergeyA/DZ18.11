namespace DZ18._11
{
    internal class GameDecorator : IGameDecorator
    {


        private BigRace team;
        private IGameDecorator game;

        public GameDecorator(BigRace team, IGameDecorator game)
        {
            this.team = team;
            this.game = game;
        }

        public void Play()
        {
            game.Play();
        }
    }
}
