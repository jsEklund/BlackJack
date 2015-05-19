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

            // Havn´t yet tried this out...
            List<Card> cardsHand;
            if (fromList.CardsInDeck.Count() != 0)
            {
                cardsHand = fromList.CardsInDeck.GetRange(0, cardsToDeal);
                HoldCards.AddRange(cardsHand);
            } else
            {
                Deck.RandomList(fromList.CardsPlayed);
                cardsHand = fromList.CardsPlayed.GetRange(0, cardsToDeal);
            }

            fromList.CardsInDeck.RemoveRange(0, cardsToDeal);
        }


    }

    
}
