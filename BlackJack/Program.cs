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
            //  Dealer.Deal(DeckCards);


            Print.PrintCard(Dealer);
            Print.PrintCard(Player);

            Console.Read();



        }

    }
}