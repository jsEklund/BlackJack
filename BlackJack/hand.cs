using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {

        public List<Card> HoldCards = new List<Card>();

        public void Deal(Deck fromList, int cardsToDeal = 1)
        {
            List<Card> cardsHand = fromList.CardsInDeck.GetRange(0, cardsToDeal);
            HoldCards.AddRange(cardsHand);
            fromList.CardsInDeck.RemoveRange(0, cardsToDeal);

            // TODO: Build functionallity to verify that deck not run out of cards.
        }


    }

    
}
