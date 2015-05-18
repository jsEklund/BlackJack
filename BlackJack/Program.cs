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

            Console.ReadKey();
            Console.WriteLine("...");

            Deck DeckCards = new Deck();
            Hand Dealer = new Hand();
            Hand Player = new Hand();

            DeckCards.AddDecks(1); // lägg till kortlek för spelet

            // Initial deal
            for (int i = 0; i < 2; i++)
            {
            
                Player.Deal(DeckCards);
                Dealer.Deal(DeckCards);

                // TODO: Calculate card values

            }

            Console.Write("Wait...");
            Console.ReadKey();



        }

    }
}