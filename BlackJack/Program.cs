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
            bool playerStand = false;
            while (Player.Sum()  < 21 && playerStand == false)
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("You have " + Player.Sum());

                Console.SetCursorPosition(0, 15);
                Console.WriteLine("Dealer have " + Dealer.Sum());

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
                        playerStand = true;
                        break;
                    
                    // Retry
                    default:
                        Print.PrintOptions();
                        break;
                }
            }

            // Dealer loop
            while (Dealer.Sum() <= 17)
            {
                Console.SetCursorPosition(0, 15);
                Console.WriteLine("Dealer have " + Dealer.Sum());

                if (Dealer.Sum() < 17)
                {
                    Dealer.Deal(DeckCards);
                    Print.PrintCard(Dealer);
                }
            }

            // result
            var dealerTotal = Dealer.Sum();
            var playerTotal = Player.Sum();
            var result = "";

            if (
                Dealer.IsBlackjack() || Player.IsBusted() || playerTotal > dealerTotal)
            {
                result = "Dealer win";
            } else if (dealerTotal == playerTotal)
            {
                result = "Push";
            } else
            {
                result = "Player win";
            }

            Console.WriteLine(result);
            Console.Read();

        }

    }
}