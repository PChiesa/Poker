using System;
namespace Poker
{
    public struct Card
    {
        public CardSuit CardSuit { get; set; }

        public CardRank CardRank { get; set; }

        public Card(CardRank rank, CardSuit suit)
        {
            CardRank = rank;
            CardSuit = suit;
        }
    }
}
