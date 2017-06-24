using System;
using System.Collections.Generic;
namespace Poker
{
    public interface ICardHand
    {
        bool HasHand(IEnumerable<Card> cards);
        CardHands Rank { get; }
    }
}
