using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class TwoPair : ICardHand
    {
        public TwoPair()
        {
        }

        public CardHands Rank => CardHands.TwoPair;

        public bool HasHand(IEnumerable<Card> cards)
        {
            return cards
                .GroupBy(c => c.CardRank)
                .Count() == 3;
        }
    }
}
