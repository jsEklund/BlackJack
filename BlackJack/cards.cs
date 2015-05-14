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

        public static void SelectState(int keypress)
        {
            switch (keypress)
            {
                // HIT
                case 1:
                //    cards.takeCards(1); // take one more card
                    Console.WriteLine("One more card");
                    break;

                // STAND
                case 2:
                    Console.WriteLine("You stay");
                    break;

                // DOUBLE UP
                case 3:
                    Console.WriteLine("You duobled");
                    break;

                // SPLIT
                case 4:
                    Console.WriteLine("You splitted");
                    break;

                // Create timeout script.
            }
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

