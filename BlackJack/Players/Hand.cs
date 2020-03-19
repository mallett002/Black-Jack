using System;
using System.Collections.Generic;
using BlackJack.Cards;

namespace BlackJack.Players
{
    public class Hand
    {
        public List<Card> CardList { get; set; }

        public Hand()
        {
            this.CardList = new List<Card>();
        }

        public void AddCard(Card card)
        {
            this.CardList.Add(card);
        }

        public void AddCards(List<Card> cards)
        {
            this.CardList.AddRange(cards);
        }

        public override string ToString()
        {
            string cards = "";

            foreach (Card card in CardList)
            {
                cards += "[ " + card.CardValue + " " + card.Suit + " ] ";
            }

            return cards;
        }
    }
}
