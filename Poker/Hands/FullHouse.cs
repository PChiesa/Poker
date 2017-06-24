using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class FullHouse : ICardHand
    {
        public FullHouse()
        {
        }

        public CardHands Rank => CardHands.FullHouse;

        public bool HasHand(IEnumerable<Card> cards)
        {
            var cardGroup = cards.GroupBy(x => x.CardRank).ToList();

            return
                cardGroup.Count == 2 &&
                cardGroup.All(x => x.Count() >= 2);
        }
    }
}
