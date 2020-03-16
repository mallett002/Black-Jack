using System;
using BlackJack.Player;

namespace BlackJack.Game
{
    public class Game
    {
        private Player.Player player;
        private Player.Player dealer;

        public Game()
        {
            this.player = new Player.Player();
            this.dealer = new Player.Player();
            dealer.Name = "Dealer";
        }

        // Todo: make getters and setters for player and dealer;

        public void InitPlayer()
        {
            Console.WriteLine("Enter your name: ");

            string readUserName = Console.ReadLine();

            player.Name = readUserName;

            Console.WriteLine("Welcome to the game {0}!", player.Name);
        }

        public override string ToString()
        {
            return "Player one: " + player.Name + "; and Dealer: "+ dealer.Name;
        }

    }
}
