using System;
using System.Text;

namespace BlackJack
{
    class Print
    {

        public static void PrintToFixedPosition(string character, int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(character);
        }

        public static void PrintCard(int card, int cardNr)
        {
            bool cardIsFirst = true;
            int cardOffsetX = 0;
            int cardOffsetY = 0;

            if (cardNr != 1)
            {
                cardIsFirst = false;
            }

            for (int i = 0; i < card; i++)
            {

            }


            if (cardIsFirst)
            {
                PrintToFixedPosition("┌───────┐", cardOffsetX + 5, cardOffsetY + 2);
            } else
            {
                PrintToFixedPosition("┌────┴──┐", cardOffsetX + 5, cardOffsetY + 2);
            }
            

            PrintToFixedPosition("│♠A     │", cardOffsetX + 5, cardOffsetY + 3);
            PrintToFixedPosition("│       │", cardOffsetX + 5, cardOffsetY + 4);
            PrintToFixedPosition("│       │", cardOffsetX + 5, cardOffsetY + 5);
            PrintToFixedPosition("│       │", cardOffsetX + 5, cardOffsetY + 6);
            PrintToFixedPosition("│     ♠A│", cardOffsetX + 5, cardOffsetY + 7);
            PrintToFixedPosition("└───────┘", cardOffsetX + 5, cardOffsetY + 8);
        }

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
            } else
            {
                addSpace.Append(s);
             
            }

            return addSpace.ToString();
        }

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
            }

            else
            {
                Environment.Exit(0);
            }
        }

        public static void PrintSelectDecks()
        {
            Console.Clear();
            Console.WriteLine(@"
              Select number of decks:" + "\n");

            Console.WriteLine(Print.CenterText("FOUR DECKS [4]     SIX DECKS [6]     EIGHT DECKS [8]"));

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

        public static void clearCardArea(int rowNr)
        {
            StringBuilder blankChar = new StringBuilder();
            blankChar.Append("");

            for (int i = 0; i < 80; i++)
            {
                blankChar.Append(" ");
            }

            Console.SetCursorPosition(0, rowNr);
            Console.Write(blankChar);
            Console.SetCursorPosition(0, rowNr);

        }

        public static void clearCardArea()
        {

        }

        public static void clearCardArea(int fromPosX, int toPosX)
        {

        }

        public static void clearCardArea(int fromPosX, int fromPosY, int toPosX, int toPosY)
        {

        }


        public static void PrintState(int keypress)
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
}
