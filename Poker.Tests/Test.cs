using NUnit.Framework;
using System;
using System.Collections.Generic;
using Poker.Hands;
namespace Poker.Tests
{
    [TestFixture]
    public class Test
    {
        IEnumerable<Card> _cardHand;

        [SetUp]
        public void SetUp()
        {
            //_cardHand = new List<Card>{
            //    new Card(CardRank.Ace, CardSymbol.Ace),
            //    new Card(CardRank.Eight, CardRank.Eight.ToString()),
            //    new Card(CardRank.Eight, CardRank.Eight.ToString()),
            //    new Card(CardRank.Two, CardRank.Two.ToString()),
            //    new Card(CardRank.Jack, CardSymbol.Jack)
            //};
        }

        [Test]
        public void IsOnePair()
        {
            _cardHand = new List<Card>{
                new Card(CardRank.Ace, CardSuit.Clubs),
                new Card(CardRank.Eight, CardSuit.Diamonds),
                new Card(CardRank.Eight, CardSuit.Spades),
                new Card(CardRank.Two, CardSuit.Spades),
                new Card(CardRank.Jack, CardSuit.Spades)
            };

            var hand = new OnePair();
            Assert.IsTrue(hand.HasHand(_cardHand));
        }

        [Test]
        public void IsTwoPair()
        {
            _cardHand = new List<Card>{
                new Card(CardRank.Ace, CardSuit.Hearts),
                new Card(CardRank.Eight, CardSuit.Spades),
                new Card(CardRank.Eight, CardSuit.Clubs),
                new Card(CardRank.Two, CardSuit.Spades),
                new Card(CardRank.Two, CardSuit.Spades)
            };

            var hand = new TwoPair();
            Assert.IsTrue(hand.HasHand(_cardHand));
        }

        [Test]
        public void IsThreeOfAKind()
        {
            _cardHand = new List<Card>{
                new Card(CardRank.Ace, CardSuit.Spades),
                new Card(CardRank.Eight, CardSuit.Hearts),
                new Card(CardRank.Eight, CardSuit.Spades),
                new Card(CardRank.Eight, CardSuit.Clubs),
                new Card(CardRank.Two, CardSuit.Spades)
            };

            var hand = new ThreeOfAKind();
            Assert.IsTrue(hand.HasHand(_cardHand));
        }

        [Test]
        public void IsStraight()
        {
            _cardHand = new List<Card>{
                new Card(CardRank.Eight, CardSuit.Spades),
                new Card(CardRank.Seven, CardSuit.Hearts),
                new Card(CardRank.Five, CardSuit.Clubs),
                new Card(CardRank.Four, CardSuit.Spades),
                new Card(CardRank.Three, CardSuit.Clubs)
            };

            var hand = new Straight();
            Assert.IsTrue(hand.HasHand(_cardHand));
        }

        [Test]
        public void IsFlush()
        {
            _cardHand = new List<Card>{
                new Card(CardRank.Eight, CardSuit.Spades),
                new Card(CardRank.Two, CardSuit.Spades),
                new Card(CardRank.Ten, CardSuit.Spades),
                new Card(CardRank.Ace, CardSuit.Spades),
                new Card(CardRank.Three, CardSuit.Spades)
            };

            var hand = new Flush();
            Assert.IsTrue(hand.HasHand(_cardHand));
        }

        [Test]
        public void IsFullHouse()
        {
            _cardHand = new List<Card>{
                new Card(CardRank.Ace, CardSuit.Clubs),
                new Card(CardRank.Two, CardSuit.Spades),
                new Card(CardRank.Two, CardSuit.Diamonds),
                new Card(CardRank.Ace, CardSuit.Hearts),
                new Card(CardRank.Two, CardSuit.Spades)
            };

            var hand = new FullHouse();
            Assert.IsTrue(hand.HasHand(_cardHand));
        }

        [Test]
        public void IsFourOfAKind()
        {
            _cardHand = new List<Card>{
                new Card(CardRank.Ace, CardSuit.Clubs),
                new Card(CardRank.Ace, CardSuit.Spades),
                new Card(CardRank.Ace, CardSuit.Diamonds),
                new Card(CardRank.Ace, CardSuit.Hearts),
                new Card(CardRank.Two, CardSuit.Spades)
            };

            var hand = new FourOfAKind();
            Assert.IsTrue(hand.HasHand(_cardHand));
        }

        [Test]
        public void IsStraightFlush()
        {
            _cardHand = new List<Card>{
                new Card(CardRank.Six, CardSuit.Clubs),
                new Card(CardRank.Five, CardSuit.Clubs),
                new Card(CardRank.Four, CardSuit.Clubs),
                new Card(CardRank.Three, CardSuit.Clubs),
                new Card(CardRank.Two, CardSuit.Clubs)
            };

            var hand = new StraightFlush();
            Assert.IsTrue(hand.HasHand(_cardHand));
        }

        [Test]
        public void IsRoyalStraightFlush()
        {
            _cardHand = new List<Card>{
                new Card(CardRank.Ace, CardSuit.Clubs),
                new Card(CardRank.King, CardSuit.Clubs),
                new Card(CardRank.Queen, CardSuit.Clubs),
                new Card(CardRank.Jack, CardSuit.Clubs),
                new Card(CardRank.Ten, CardSuit.Clubs)
            };

            var hand = new RoyalStraightFlush();
            Assert.IsTrue(hand.HasHand(_cardHand));
        }

        [Test]
        public void PlayerOneShouldWin()
        {

            var player1 = new Player("Player1");
            player1.Cards = new List<Card>{
                new Card(CardRank.Ace, CardSuit.Clubs),
                new Card(CardRank.King, CardSuit.Clubs),
                new Card(CardRank.Queen, CardSuit.Clubs),
                new Card(CardRank.Jack, CardSuit.Clubs),
                new Card(CardRank.Ten, CardSuit.Clubs)
            };

            var player2 = new Player("Player2");
            player2.Cards = CardHandGenerator.GenerateHand();

            List<Player> players = new List<Player>() { player1, player2 };

            Player winningPlayer = new CardHandValidator().ValidatePlayerHands(players);

            Console.WriteLine(winningPlayer.Hand.ToString());
            Console.WriteLine(player2.Hand);

            Assert.AreEqual(player1.Name, winningPlayer.Name);

        }

        [Test]
        public void MatchShouldDraw()
        {

            var player1 = new Player("Player1");
            player1.Cards = new List<Card>{
                new Card(CardRank.Ace, CardSuit.Clubs),
                new Card(CardRank.King, CardSuit.Clubs),
                new Card(CardRank.Queen, CardSuit.Clubs),
                new Card(CardRank.Jack, CardSuit.Clubs),
                new Card(CardRank.Ten, CardSuit.Clubs)
            };

            var player2 = new Player("Player2");
            player2.Cards = new List<Card>{
                new Card(CardRank.Ace, CardSuit.Clubs),
                new Card(CardRank.King, CardSuit.Clubs),
                new Card(CardRank.Queen, CardSuit.Clubs),
                new Card(CardRank.Jack, CardSuit.Clubs),
                new Card(CardRank.Ten, CardSuit.Clubs)
            };

            List<Player> players = new List<Player>() { player1, player2 };

            Player winningPlayer = new CardHandValidator().ValidatePlayerHands(players);

            Console.WriteLine(winningPlayer.Hand.ToString());
            Console.WriteLine(player2.Hand);

            Assert.AreEqual(player1.Name, winningPlayer.Name);

        }
    }
}
