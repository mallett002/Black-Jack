using System;
using BlackJack.Game;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play some Black Jack!");

            GameManager gameManager = new GameManager(); // makes players with hands

            gameManager.InitPlayer(); // sets players names and start with 2 cards

            
        }
    }
}
