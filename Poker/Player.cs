using System;
using System.Collections.Generic;
namespace Poker
{
    public class Player
    {
        public string Name { get; set; }

        public IEnumerable<Card> Cards { get; set; }

        public CardHands Hand { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
