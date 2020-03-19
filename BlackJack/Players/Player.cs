using System;
using System.Collections.Generic;
using System.Text;
using BlackJack.Cards;

namespace BlackJack.Players
{
    public class Player
    {
        public Player()
        {
            Hand = new Hand();

        }

        public Hand Hand { get; set; }
        public string Name { get; set; }
    }
}
