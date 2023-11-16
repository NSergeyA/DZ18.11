using System.Collections.Generic;

namespace DZ18._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IGameDecorator> gamesList = new List<IGameDecorator>();
            Organisator organisator = new Organisator("Оливье Ганьян");
            List<Player> russia = new List<Player>();
            Player ruplayer1 = new Player("Игрок 1", Country.Россия);
            russia.Add(ruplayer1);
            Player ruplayer2 = new Player("Игрок 2", Country.Россия);
            russia.Add(ruplayer2);
            Player ruplayer3 = new Player("Игрок 3", Country.Россия);
            russia.Add(ruplayer3);
            Player ruplayer4 = new Player("Игрок 4", Country.Россия);
            russia.Add(ruplayer4);
            Player ruplayer5 = new Player("Игрок 5", Country.Россия);
            russia.Add(ruplayer5);
            Player ruplayer6 = new Player("Игрок 6", Country.Россия);
            russia.Add(ruplayer6);
            Player ruplayer7 = new Player("Игрок 7", Country.Россия);
            russia.Add(ruplayer7);
            Player ruplayer8 = new Player("Игрок 8", Country.Россия);
            russia.Add(ruplayer8);
            Player ruplayer9 = new Player("Игрок 9", Country.Россия);
            russia.Add(ruplayer9);
            Player ruplayer10 = new Player("Игрок 10", Country.Россия);
            russia.Add(ruplayer10);
            Player ruplayer11 = new Player("Игрок 11", Country.Россия);
            russia.Add(ruplayer11);
            Player ruplayer12 = new Player("Игрок 12", Country.Россия);
            russia.Add(ruplayer12);
            Player ruplayer13 = new Player("Игрок 13", Country.Россия);
            russia.Add(ruplayer13);
            Player ruplayer14 = new Player("Игрок 14", Country.Россия);
            russia.Add(ruplayer14);
            Player ruplayer15 = new Player("Игрок 15", Country.Россия);
            russia.Add(ruplayer15);

            gamesList.Add(new Beach());
            gamesList.Add(new MouseTrap());
            gamesList.Add(new Sea());
            gamesList.Add(new Fishing());
            gamesList.Add(new Postmen());
            gamesList.Add(new Slide());
            BigRace team_rus = new BigRace(russia, gamesList);

            List<Player> france = new List<Player>();
            Player fplayer1 = new Player("Игрок 1", Country.Франция);
            france.Add(fplayer1);
            Player fplayer2 = new Player("Игрок 2", Country.Франция);
            france.Add(fplayer2);
            Player fplayer3 = new Player("Игрок 3", Country.Франция);
            france.Add(fplayer3);
            Player fplayer4 = new Player("Игрок 4", Country.Франция);
            france.Add(fplayer4);
            Player fplayer5 = new Player("Игрок 5", Country.Франция);
            france.Add(fplayer5);
            Player fplayer6 = new Player("Игрок 6", Country.Франция);
            france.Add(fplayer6);
            Player fplayer7 = new Player("Игрок 7", Country.Франция);
            france.Add(fplayer7);
            Player fplayer8 = new Player("Игрок 8", Country.Франция);
            france.Add(fplayer8);
            Player fplayer9 = new Player("Игрок 9", Country.Франция);
            france.Add(fplayer9);
            Player fplayer10 = new Player("Игрок 10", Country.Франция);
            france.Add(fplayer10);
            Player fplayer11 = new Player("Игрок 11", Country.Франция);
            france.Add(fplayer11);
            Player fplayer12 = new Player("Игрок 12", Country.Франция);
            france.Add(fplayer12);
            Player fplayer13 = new Player("Игрок 13", Country.Франция);
            france.Add(fplayer13);
            Player fplayer14 = new Player("Игрок 14", Country.Франция);
            france.Add(fplayer14);
            Player fplayer15 = new Player("Игрок 15", Country.Франция);
            france.Add(fplayer15);
            BigRace team_france = new BigRace(france, gamesList);


            List<Player> kazakhstan = new List<Player>();
            Player kzh_player1 = new Player("Игрок 1", Country.Казахстан);
            kazakhstan.Add(kzh_player1);
            Player kzh_player2 = new Player("Игрок 2", Country.Казахстан);
            kazakhstan.Add(kzh_player2);
            Player kzh_player3 = new Player("Игрок 3", Country.Казахстан);
            kazakhstan.Add(kzh_player3);
            Player kzh_player4 = new Player("Игрок 4", Country.Казахстан);
            kazakhstan.Add(kzh_player4);
            Player kzh_player5 = new Player("Игрок 5", Country.Казахстан);
            kazakhstan.Add(kzh_player5);
            Player kzh_player6 = new Player("Игрок 6", Country.Казахстан);
            kazakhstan.Add(kzh_player6);
            Player kzh_player7 = new Player("Игрок 7", Country.Казахстан);
            kazakhstan.Add(kzh_player7);
            Player kzh_player8 = new Player("Игрок  8", Country.Казахстан);
            kazakhstan.Add(kzh_player8);
            Player kzh_player9 = new Player("Игрок 9", Country.Казахстан);
            kazakhstan.Add(kzh_player9);
            Player kzh_player10 = new Player("Игрок 10", Country.Казахстан);
            kazakhstan.Add(kzh_player10);
            Player kzh_player11 = new Player("Игрок 11", Country.Казахстан);
            kazakhstan.Add(kzh_player11);
            Player kzh_player12 = new Player("Игрок 12", Country.Казахстан);
            kazakhstan.Add(kzh_player12);
            Player kzh_player13 = new Player("Игрок 13", Country.Казахстан);
            kazakhstan.Add(kzh_player13);
            Player kzh_player14 = new Player("Игрок 14", Country.Казахстан);
            kazakhstan.Add(kzh_player14);
            Player kzh_player15 = new Player("Игрок 15", Country.Казахстан);
            kazakhstan.Add(kzh_player15);
            BigRace team_kazakhstan = new BigRace(kazakhstan, gamesList);

            List<Player> china = new List<Player>();
            Player chn_player1 = new Player("Игрок 1", Country.Китай);
            china.Add(chn_player1);
            Player chn_player2 = new Player("Игрок 2", Country.Китай);
            china.Add(chn_player2);
            Player chn_player3 = new Player("Игрок 3", Country.Китай);
            china.Add(chn_player3);
            Player chn_player4 = new Player("Игрок 4", Country.Китай);
            china.Add(chn_player4);
            Player chn_player5 = new Player("Игрок 5", Country.Китай);
            china.Add(chn_player5);
            Player chn_player6 = new Player("Игрок 6", Country.Китай);
            china.Add(chn_player6);
            Player chn_player7 = new Player("Игрок 7", Country.Китай);
            china.Add(chn_player7);
            Player chn_player8 = new Player("Игрок 8", Country.Китай);
            china.Add(chn_player8);
            Player chn_player9 = new Player("Игрок 9", Country.Китай);
            china.Add(chn_player9);
            Player chn_player10 = new Player("Игрок 10", Country.Китай);
            china.Add(chn_player10);
            Player chn_player11 = new Player("Игрок 11", Country.Китай);
            china.Add(chn_player11);
            Player chn_player12 = new Player("Игрок 12", Country.Китай);
            china.Add(chn_player12);
            Player chn_player13 = new Player("Игрок 13", Country.Китай);
            china.Add(chn_player13);
            Player chn_player14 = new Player("Игрок 14", Country.Китай);
            china.Add(chn_player14);
            Player chn_player15 = new Player("Игрок 15", Country.Китай);
            china.Add(chn_player15);
            BigRace team_china = new BigRace(china, gamesList);





        }
    }
}
