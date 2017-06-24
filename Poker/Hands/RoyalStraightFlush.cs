using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class RoyalStraightFlush : ICardHand
    {
        public RoyalStraightFlush()
        {
        }

        public CardHands Rank => CardHands.RoyalStraightFlush;

        public bool HasHand(IEnumerable<Card> cards)
        {
            return
                new Straight().HasHand(cards) &&
                new Flush().HasHand(cards) &&
                cards.OrderBy(x => x.CardRank).First().CardRank == CardRank.Ten;
        }
    }
}
