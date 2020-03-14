using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Hand
    {
        private List<Card> cards;

        public Hand(){ this.cards = new List<Card>(); }

        public List<Card> GetCards() { return this.cards; }

        public void SetCards(List<Card> cards) { this.cards.AddRange(cards); }

        public void AddCard(Card card) { this.cards.Add(card); }
    }
}
