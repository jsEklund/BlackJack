using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public Value Value;
        public Suit Suit;

        public static int CheckCardValue(Card card)
        {
            int result = 0;
            if ((int)card.Value >= 10)
            {
                result = 10;
            } else
            {
                result = (int)card.Value;
            }
            return result;
        }

    }

    enum Suit
    {
        Diamnods,
        Hearts,
        Spades,
        Clubs
    }

    enum Value
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

}

