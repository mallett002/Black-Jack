using System;
using BlackJack.Game;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play some Black Jack!");

            Game.Game game = new BlackJack.Game.Game();

            game.InitPlayer();

            Console.WriteLine(game.ToString());
        }
    }
}
