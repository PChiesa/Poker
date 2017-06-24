using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class ThreeOfAKind : ICardHand
    {
        public ThreeOfAKind()
        {
        }

        public CardHands Rank => CardHands.ThreeOfAKind;

        public bool HasHand(IEnumerable<Card> cards)
        {
            var cardGroup = cards.GroupBy(c => c.CardRank);

            return
                cardGroup.Count() == 3 &&
                cardGroup.Any(x => x.Count() == 3);
        }
    }
}
