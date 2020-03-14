using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class CardFactory
    {
        Random random;

        public CardFactory()
        {
            this.random = new Random();
        }

        enum Suits
        {
            HEARTS,
            DIAMONDS,
            SPADES,
            CLUBS
        }

        enum FaceCard
        {
            JACK,
            QUEEN,
            KING,
            ACE
        }

        public string GenerateCardValue()
        {
            int num = random.Next(2, 14);

            if (num > 10)
            {
                Array values = Enum.GetValues(typeof(FaceCard));
                FaceCard card = (FaceCard) values.GetValue(random.Next(values.Length));
                return card.ToString();
            }

            return num.ToString();
        }

        public string GetSuit()
        {
            Array values = Enum.GetValues(typeof(Suits));
            Suits suit = (Suits) values.GetValue(random.Next(values.Length));
            return suit.ToString();
        }
    }


}
