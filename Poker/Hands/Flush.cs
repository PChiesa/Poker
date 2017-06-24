using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class Flush : ICardHand
    {
        public Flush()
        {
        }

        public CardHands Rank => CardHands.Flush;

        public bool HasHand(IEnumerable<Card> cards)
        {
            return cards.GroupBy(x => x.CardSuit).Count() == 1;
        }
    }
}
