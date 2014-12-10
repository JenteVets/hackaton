using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague
{
    public class Player1
    {
        private int nummer;
        private string naam;

        public int Nummer
        {
            get { return nummer; }
            set { nummer = value; }
        }
        
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public Player1(int nummer, string naam)
        {
            Nummer = nummer;
            Naam = naam;
        }
    }

    public class Player2
    {
        public int Nummer { get; set; }
        public string Naam { get; set; }
        
        public Player2(int nummer, string naam)
        {
            Nummer = nummer;
            Naam = naam;
        }
    }

    public class Player3
    {
        public int Nummer { get; set; }
        public string Naam { get; set; }
    }

    public static class TestPlayer
    {
        static TestPlayer()
        {
            Player1 player1 = new Player1(11, "Bert");
            player1.Naam = "Bertus";

            Player2 player2 = new Player2(10, "Stef");
            player2.Naam = "Stefaan";

            Player3 player3 = new Player3 { Nummer = 9, Naam = "Jef" };
            player3.Naam = "Jeff";
        }
    }

}
