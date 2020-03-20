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

        public int GetHandValue()
        {
            int sum = 0;

            foreach (Card card in CardList)
            {
                if (Enum.IsDefined(typeof(CardFactory.FaceCard), card.CardValue)) // if is facecard
                {
                    if (card.CardValue == nameof(CardFactory.FaceCard.ACE)) // if is Ace
                    {
                        int possibleSum = sum + 11;

                        if (possibleSum > 21) // if sum is greater than 21, just add 1
                        {
                            sum += 1;
                        }
                        else
                        {
                            sum = possibleSum;
                        }
                    }
                    else
                    {
                        sum += 10;
                    }
                }
                else
                {
                    sum += Int32.Parse(card.CardValue); // if not facecard, just add value
                }             
            }

            return sum;
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
