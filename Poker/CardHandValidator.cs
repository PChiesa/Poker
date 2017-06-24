using System;
using System.Linq;
using System.Collections.Generic;

namespace Poker
{
    public class CardHandValidator
    {
        Type CardHandType = typeof(ICardHand);
        IEnumerable<ICardHand> _allCardHands;

        public CardHandValidator()
        {
            _allCardHands = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => CardHandType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => (ICardHand)Activator.CreateInstance(x))
                .OrderByDescending(x => x.Rank);

        }

        public Player ValidatePlayerHands(List<Player> players)
        {
            Player currentWinningPlayer = null;

            foreach (var player in players)
            {
                foreach (var cardHand in _allCardHands)
                {
                    if (player.Hand > cardHand.Rank)
                        break;

                    if (cardHand.HasHand(player.Cards))
                    {
                        player.Hand = cardHand.Rank;

                        if (currentWinningPlayer == null)
                        {
                            currentWinningPlayer = player;
                            continue;
                        }

                        if (player.Hand > currentWinningPlayer.Hand)
                            currentWinningPlayer = player;
                    }
                }
            }

            return currentWinningPlayer;
        }
    }
}
