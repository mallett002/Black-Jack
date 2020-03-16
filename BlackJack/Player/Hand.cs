using System;
using System.Collections.Generic;
using BlackJack.Card;

namespace BlackJack.Player
{
    class Hand
    {
        private List<Card.Card> cards;

        public Hand(){ this.cards = new List<Card.Card>(); }

        public List<Card.Card> GetCards() { return this.cards; }

        public void SetCards(List<Card.Card> cards) { this.cards.AddRange(cards); }

        public void AddCard(Card.Card card) { this.cards.Add(card); }
    }
}
