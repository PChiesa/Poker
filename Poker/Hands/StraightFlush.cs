using System;
using System.Collections.Generic;

namespace Poker.Hands
{
    public class StraightFlush : ICardHand
    {
        public StraightFlush()
        {
        }

        public CardHands Rank => CardHands.StraightFlush;

        public bool HasHand(IEnumerable<Card> cards)
        {
            return
                new Straight().HasHand(cards) &&
                new Flush().HasHand(cards);
        }
    }
}
