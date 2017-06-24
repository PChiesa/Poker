using System;
using System.Collections.Generic;
namespace Poker
{
    public class CardHandGenerator
    {
        const int MaxCardsInHand = 5;

        public CardHandGenerator()
        {
        }

        public static IEnumerable<Card> GenerateHand(){

            var cardHand = new List<Card>();
            var random = new Random();

            for (int i = 0; i < MaxCardsInHand; i++)
            {
                int rank = random.Next((int)CardRank.Two, (int)CardRank.Ace);
                int suit = random.Next((int)CardSuit.Clubs, (int)CardSuit.Diamonds);

                cardHand.Add(new Card((CardRank)rank, (CardSuit)suit));
            }

            return cardHand;
        }
    }
}
