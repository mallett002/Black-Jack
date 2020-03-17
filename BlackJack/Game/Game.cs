using System;
using BlackJack.Players;

namespace BlackJack.Game
{
    public class GameManager
    {
        // public getters and setters
        public Player Player { get; set; }
        public Player Dealer { get; set; }

        public GameManager()
        {
            this.Player = new Player();
            this.Dealer = new Player();
            Dealer.Name = "Dealer";
        }

        public void InitPlayer()
        {
            Console.WriteLine("Enter your name: ");

            string readUserName = Console.ReadLine();

            Player.Name = readUserName;

            Console.WriteLine("Welcome to the game {0}!", Player.Name);
        }

        public override string ToString()
        {
            return "Player one: " + Player.Name + "; and Dealer: "+ Dealer.Name;
        }

    }
}
