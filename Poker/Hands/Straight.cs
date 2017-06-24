using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Hands
{
    public class Straight : ICardHand
    {
        public Straight()
        {
        }

        public CardHands Rank => CardHands.Straight;

        public bool HasHand(IEnumerable<Card> cards)
        {
            var cardOrdered = cards.OrderBy(x => x.CardRank).ToList();

            bool isStraight = false;

            for (int i = 0; i < cardOrdered.Count - 1; i++)
            {
                isStraight =
                    cardOrdered[i + 1].CardRank - cardOrdered[i].CardRank == 1;
            }

            return isStraight;
        }
    }
}
