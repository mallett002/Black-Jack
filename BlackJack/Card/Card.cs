using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.Card
{
    class Card
    {
        int value;
        string suit;
        CardFactory cardFactor;

        public Card()
        {
            this.cardFactor = new CardFactory();
            SetCardValue();
            SetCardSuit();
        }

        private void SetCardValue()
        {
            string value = cardFactor.GenerateCardValue();
            this.value = Int32.Parse(value);
        }

        private void SetCardSuit()
        {
            this.suit = cardFactor.GetSuit();
        }
    }
}
