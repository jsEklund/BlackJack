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

            // Print game area
            Print.createGameArea();

            // Initial deal
            for (int i = 0; i < 2; i++)
            {
                Player.Deal(DeckCards);
                Dealer.Deal(DeckCards);
            }

            // Print cards
            Print.PrintCard(Dealer);
            Print.PrintCard(Player);

            // Select what to do
            Print.PrintOptions();

            // Player loop
            while (Player.Sum < 21)
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
                        break;
                    
                    // Retry
                    default:
                        Print.PrintOptions();
                        break;
                }
            }

            // Dealer loop
            while (Dealer.Sum <= 17)
            {
                if (Dealer.Sum < 17)
                {
                    // Deal;
                    Dealer.Deal(DeckCards);
                    Print.PrintCard(Dealer);
                }

                else if (Dealer.Sum <= 21)
                {
                    // Stand;
                    Console.WriteLine("Stand");
                    break;
                }

                else
                {
                    // Busted;
                    Console.WriteLine("Busted");
                    break;
                }
            }
            
            Console.Read();

        }

    }
}