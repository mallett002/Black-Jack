using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.Player
{
    class Player
    {
        private string name;
        private Hand cards;

        public string Name 
        {
            get => name;
            set => name = value;
        }
        public Hand Cards { get; set; }
    }
}
