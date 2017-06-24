using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class OnePair : ICardHand
    {
        public OnePair()
        {
        }

        public CardHands Rank => CardHands.OnePair;

        public bool HasHand(IEnumerable<Card> cards)
        {
            return cards
                .GroupBy(c => c.CardRank).Count() == 4;
                //.Any(x => x.Count() == 2);
        }
    }
}
