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
            Console.WriteLine(Print.CenterText("Welcome to BlackJack!"));
            Console.WriteLine();

            // Instructions or play
            Console.WriteLine(Print.CenterText("INSRTUCTIONS [I]     PLAY [P]     EXIT [Esc]"));

            // Instructions page
            Console.WriteLine(Print.CenterText("BACK [B]     EXIT [Esc]"));

            // Play P > Select decks
            Console.WriteLine(Print.CenterText("Select number of decks:"));
            Console.WriteLine(Print.CenterText("FOUR DECKS [4]     SIX DECKS [6]     EIGHT DECKS [8]"));
            
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