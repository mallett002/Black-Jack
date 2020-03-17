using System;
using BlackJack.Game;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play some Black Jack!");

            GameManager gameManager = new GameManager();

            gameManager.InitPlayer();

            
        }
    }
}
