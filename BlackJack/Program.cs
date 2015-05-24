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
            
            // Play
            Deck DeckCards = new Deck();
            Hand Dealer = new Hand();
            Hand Player = new Hand();

            // Add decks
            Print.AddDecksToGame(DeckCards);
            

            // Initial deal
            for (int i = 0; i < 2; i++)
            {
            
                Player.Deal(DeckCards);
                Dealer.Deal(DeckCards);

                // TODO: Calculate card values...

            }


            // Just testing...
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