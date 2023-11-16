using System.Collections.Generic;

namespace DZ18._11
{
    internal class BigRace
    {
        private List<Player> players;
        public List<Player> Players = new List<Player>();
        private List<IGameDecorator> gamesList;
        public List<IGameDecorator> GamesList = new List<IGameDecorator>();



        public BigRace()
        {

        }
        public BigRace(List<Player> players)
        {
            this.players = players;
        }
        public BigRace(List<Player> players, List<IGameDecorator> gamesList)
        {
            this.players = players;
            this.gamesList = gamesList;
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void PlayGames()
        {
            foreach (var game in gamesList)
            {
                game.Play();
            }
        }
        public void AddGame(IGameDecorator game)
        {
            gamesList.Add(game);
        }


    }
}
