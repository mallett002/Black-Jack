using System;
using System.Collections.Generic;
using BlackJack.Players;
using BlackJack.Cards;

namespace BlackJack.Game
{
    public class GameManager
    {
        // public getters and setters
        public Player Player { get; set; }
        public Player Dealer { get; set; }
        public CardFactory factory = new CardFactory();

        public GameManager()
        {
            this.Player = new Player();
            this.Dealer = new Player();
            Dealer.Name = "Dealer";
        }

        // Make a new player with a hand of 2 cards
        public void InitPlayer()
        {
            Console.WriteLine("Enter your name: ");

            string readUserName = Console.ReadLine();

            Player.Name = readUserName;

            SetPlayerCards();

            Console.WriteLine("{0}'s hand: {1}", Player.Name, Player.Hand);
            Console.WriteLine("dealer's hand: {0}", Dealer.Hand);

        }

        private void SetPlayerCards()
        {
            // Player One
            Card cardOne = factory.GenerateCard();
            Card cardTwo = factory.GenerateCard();

            List<Card> playerOneCards = new List<Card>();
            playerOneCards.Add(cardOne);
            playerOneCards.Add(cardTwo);

            Player.Hand.AddCards(playerOneCards);

            // Dealer
            Card dealerOne = factory.GenerateCard();
            Card dealerTwo = factory.GenerateCard();

            List<Card> dealerCards = new List<Card>();
            dealerCards.Add(dealerOne);
            dealerCards.Add(dealerTwo);

            Dealer.Hand.AddCards(dealerCards);

        }

        public override string ToString()
        {
            return "Player one: " + Player.Name + "; and Dealer: "+ Dealer.Name;
        }

    }
}
