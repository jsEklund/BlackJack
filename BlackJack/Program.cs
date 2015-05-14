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

            Deck newDeck = new Deck();
            Hand dealer = new Hand();
            Hand player = new Hand();

            
            newDeck.AddDecks(1);








//            newDeck.TakeCards(10);

            Console.Write("Wait...");
            Console.ReadKey();



        }

    }
}