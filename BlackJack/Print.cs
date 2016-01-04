using System;
using System.Text;
using System.Collections.Generic;

namespace BlackJack
{
    class Print
    {

        public static void createGameArea()
        {
            Console.SetCursorPosition(15, 3);
            Console.SetCursorPosition(15, 14);
        }

        public static void AddDecksToGame(Deck deck)
        {
            Console.Clear();
            Console.WriteLine(@"      Select number of decks:" + "\n");

            Console.WriteLine(Print.CenterText("FOUR DECKS [4]     SIX DECKS [6]     EIGHT DECKS [8]      EXIT [ESC]"));

                var inputDecks = Console.ReadKey();
                switch (inputDecks.Key)
                {
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        deck.AddDecks(4);
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        deck.AddDecks(6);
                        break;

                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        deck.AddDecks(8);
                        break;

                    default:
                        AddDecksToGame(deck);
                        break;
                }
                Console.Clear();
        }

        public static void clearCardArea(int rowNr)
        {
            StringBuilder blankChar = new StringBuilder();

            int consoleWidth = Console.WindowWidth;

            for (int i = 0; i < consoleWidth; i++)
            {
                blankChar.Append(" ");
            }

            Console.SetCursorPosition(0, rowNr);
            Console.Write(blankChar);
            Console.SetCursorPosition(0, rowNr);

        }

        #region Print pages methods

        public static void PrintIntroPage()
        {
            Console.Clear();
            Console.WriteLine(Print.CenterText("Welcome to BlackJack!"));
            Console.WriteLine();
            Console.WriteLine("               BlackJack is a card game. Read more in the                       ");
            Console.WriteLine("               instructions page.                                               ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Print.CenterText("INSRTUCTIONS [i]     PLAY [p]     EXIT [Esc]"));

            var input = Console.ReadKey();

            if (input.Key == ConsoleKey.I)
            {
                Print.PrintInstructionPage();
            }
            else if (input.Key == ConsoleKey.P)
            {
                //                PrintSelectDecks();
            }

            else
            {
                Environment.Exit(0);
            }
        }

        public static void PrintInstructionPage()
        {
            string s = @"
               ┌───────┐  Blackjack, also known as twenty-one, is
               │♠A     │  the mostwidely played casino banking
               │  ┌────┴──┐  game in the world.
               │  │♠J     │     
               │  │       │  Blackjack is a comparing card game
               │  │       │  between a playerand dealer meaning
               │  │       │  that playerscompete against the
               └──┤       │  dealer but notagainst any other
                  │     ♠J│  players.
                  └───────┘

               It is played with one or more decks of 52 cards.
               The object of the game is to beat the dealer,
               which can be done in a number of ways:

               # Get 21 points on the player's first two cards
                 (called a blackjack), without a dealer blackjack.

               # Reach a final score higher than the dealer
                 without exceeding 21.

               # Let the dealer draw additional cards until his or
                 her hand exceeds 21.

                " + "\n";

            Console.Clear();
            Console.Write(s);

            Console.WriteLine(Print.CenterText("BACK [b]     EXIT [Esc]"));

            var input = Console.ReadKey();

            if (input.Key == ConsoleKey.B)
            {
                PrintIntroPage();
            }
            else
            {
                Environment.Exit(0);
            }
        }


        public static void PrintOptions()
        {
            Console.SetCursorPosition(0, 13);
            Console.WriteLine(CenterText("HIT [h]     STAND [s]"));
        }

        #endregion

        #region Return card methods

        private static string returnSuit(Card card)
        {
            string suit = "";

            switch (card.Suit)
            {
                case Suit.Diamnods:
                    suit = "♦";
                    break;

                case Suit.Hearts:
                    suit = "♥";
                    break;

                case Suit.Spades:
                    suit = "♠";
                    break;

                case Suit.Clubs:
                    suit = "♣";
                    break;
            }
            return suit;
        }

        private static string ReturnValue(Card card)
        {
            string value;

            switch (card.Value)
            {
                case Value.Ace:
                    value = "A";
                    break;

                case Value.Jack:
                    value = "J";
                    break;

                case Value.Queen:
                    value = "D";
                    break;

                case Value.King:
                    value = "K";
                    break;

                default:
                    value = ((int)card.Value).ToString();
                    break;

            }

            return value;
        }

        #endregion


        public static string CenterText(string s)
        {
            int spaceBefore = (Console.WindowWidth - s.Length) / 2;
            StringBuilder addSpace = new StringBuilder();

            for (int i = 0; i < 80; i++)
            {
                addSpace.Append(" ");
            }

            if (s.Length <= 80)
            {
                addSpace.Insert(spaceBefore, s);
            }
            else
            {
                addSpace.Append(s);

            }

            return addSpace.ToString();
        }

        #region Print card methods

        public static void PrintCard(Hand hand)
        {
            int cardPosX = 1;
            int cardPosY = 5;

            for (int i = 0; i < hand.HoldCards.Count; i++)
            {
                Card card = hand.HoldCards[i];
                bool isFirst = false;

                if (i == 0)
                {
                    isFirst = true;
                }

                if (hand.isDealer)
                {
                    cardPosX = (i * 4) + 1;
                    cardPosY = 5;

                    PrintToFixedPosition(card, hand.isDealer, isFirst, cardPosX, cardPosY);
                }

                else
                {
                    cardPosX = (i * 3) + 1;
                    cardPosY = (i * 2) + 17;

                    PrintToFixedPosition(card, hand.isDealer, isFirst, cardPosX, cardPosY);
                }

            }
        }

        private static void PrintToFixedPosition(Card card, bool isDealer, bool isFirst, int posX, int posY)
        {
            string cardValue = ReturnValue(card);
            string cardSuit = returnSuit(card);
            string cardString = cardSuit + cardValue;

            if (isDealer)
            {
                PrintDealerCard(cardString, isFirst, posX, posY);
            }

            else
            {
                PrintPlayerCard(cardString, isFirst, posX, posY);
            }
        }

        private static void PrintDealerCard(string cardValue, bool isFirst, int posX, int posY)
        {
            if (isFirst)
            {
                PrintCardRow("┌───────┐", posX, posY);
            }
            else
            {
                PrintCardRow("┬───────┐", posX, posY);
            }

            PrintCardRow(string.Format("│{0,-3}    │", cardValue), posX, posY + 1);

            PrintCardRow("│       │", posX, posY + 2);
            PrintCardRow("│       │", posX, posY + 3);
            PrintCardRow("│       │", posX, posY + 4);
            PrintCardRow("│       │", posX, posY + 5);

            PrintCardRow(string.Format("│    {0,3}│", cardValue), posX, posY + 6);

            if (isFirst)
            {
                PrintCardRow("└───────┘", posX, posY + 7);
            }

            else
            {
                PrintCardRow("┴───────┘", posX, posY + 7);
            }
        }

        private static void PrintPlayerCard(string cardValue, bool isFirst, int posX, int posY)
        {
            if (isFirst)
            {
                PrintCardRow("┌───────┐", posX, posY);
            }

            else
            {
                PrintCardRow("┌────┴──┐", posX, posY);
            }

            PrintCardRow(string.Format("│{0,-3}    │", cardValue), posX, posY + 1);

            PrintCardRow("│       │", posX, posY + 2);
            PrintCardRow("│       │", posX, posY + 3);
            PrintCardRow("│       │", posX, posY + 4);

            if (isFirst)
            {
                PrintCardRow("│       │", posX, posY + 5);
            }

            else
            {
                PrintCardRow("┤       │", posX, posY + 5);
            }

            PrintCardRow(string.Format("│    {0,3}│", cardValue), posX, posY + 6);

            PrintCardRow("└───────┘", posX, posY + 7);
        }

        private static void PrintCardRow(string s, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine(s);
        }

        #endregion

    }
}
