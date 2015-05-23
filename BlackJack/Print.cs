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

            addSpace.Insert(spaceBefore, s);

            return addSpace.ToString();
        }

        public static void PrintIntro()
        {
            string s = "- WELCOME TO BLACKJACK -";



            Console.WriteLine(CenterText(s));


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
