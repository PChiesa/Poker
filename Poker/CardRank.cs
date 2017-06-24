using System;
using System.ComponentModel;

namespace Poker
{
    public enum CardRank
    {
        [Description("Joker")]
        Joker = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        [Description("Jack")]
        Jack,
        [Description("Queen")]
        Queen,
        [Description("King")]
        King,
        [Description("Ace")]
        Ace
    }
}
