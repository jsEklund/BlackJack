using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {
        public List<Card> CardsInHands;

        public List<Card> HoldCards = new List<Card>();

        public List<Card> ReturnCards(Deck decksInGame, int players)
        {
            int dealerCards = 1, playerCards = players * 2;

            decksInGame.TakeCards(playerCards + dealerCards);
            // decksInGame now contains all player cards


            /*
            for (int i = 0; i < players; i++)
            {
                Hand player[i] = new Hand();

                for (int cards = 0; cards < decksInGame.; cards++)
                {

                }

            }
            */
        }


    }

    
}
