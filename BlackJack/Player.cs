using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Player
    {
        private string name;
        private Hand cards;

        public Player(string name) => this.name = name;

        public string Name 
        {
            get => name;
            set => name = value;
        }
        public Hand Cards { get; set; }
    }
}
