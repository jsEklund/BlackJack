using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {

        static void Main(string[] args)
        {

            // Intro
            Print.PrintIntroPage();

            /*
            switch (input.Key)
            {
                case ConsoleKey.I:
                    Print.printInstructionPage();
                    break;
                case ConsoleKey.P:
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                    
                default:
                    break;
            }
            */


            // Instructions page
            Print.PrintSelectDecks();
            
            
            // Info page
            // You have selected X decks. Add some details. start | back | exit

            Deck DeckCards = new Deck();
            Hand Dealer = new Hand();
            Hand Player = new Hand();

            DeckCards.AddDecks(1); // lägg till kortlek för spelet

            // Initial deal
            for (int i = 0; i < 2; i++)
            {
            
                Player.Deal(DeckCards);
                Dealer.Deal(DeckCards);

                // TODO: Calculate card values...

            }

            //   Console.Write("Wait...");

          //  Print.PrintIntro();

          //  Print.PrintCard(1, 2);
            
          //  Console.WriteLine("new row");

          //  Console.SetCursorPosition(30, 40);

            //   Print.clearCardArea(10);

            Console.Read();



        }

    }
}