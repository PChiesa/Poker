using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class FourOfAKind : ICardHand
    {
        public FourOfAKind()
        {
        }

        public CardHands Rank => CardHands.FourOfAKind;

        public bool HasHand(IEnumerable<Card> cards)
        {
            var cardGroup = cards.GroupBy(x => x.CardRank).ToList();

            return
                cardGroup.Count == 2 &&
                cardGroup.Any(x => x.Count() == 4);
        }
    }
}
