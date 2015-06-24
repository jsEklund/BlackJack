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
            Hand Dealer = new Hand(true);
            Hand Player = new Hand(false);

            // Add decks
            Print.AddDecksToGame(DeckCards);



            Print.createGameArea();

            // Initial deal
            for (int i = 0; i < 2; i++)
            {
                Player.Deal(DeckCards);
                Dealer.Deal(DeckCards);

                // TODO: Calculate card values...

            }

            Print.PrintCard(Dealer);
            Print.PrintCard(Player);

            Print.PrintOptions();
            
            bool playersTurn = true;

            // Player loop
            while (playersTurn)
            {
                var input = Console.ReadKey();
                Print.clearCardArea(42);

                switch (input.Key)
                {
                    // Hit
                    case ConsoleKey.H:
                        Player.Deal(DeckCards);
                        Print.PrintCard(Player);
                        Print.PrintOptions();
                        continue;

                    // Stand
                    case ConsoleKey.S:
                        playersTurn = false;
                        break;
                    
                    default:
                        Print.PrintOptions();
                        break;
                }
            }

            // Dealer loop

            Console.Read();

        }

    }
}