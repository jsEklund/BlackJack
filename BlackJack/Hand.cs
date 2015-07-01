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
        public bool isDealer;
        public int Sum
        {
            get
            {
                return this.CalculateSum();
            }
        }

        public Hand(bool isDealer)
        {
            this.isDealer = isDealer;
        }

        public void Deal(Deck fromList, int cardsToDeal = 1)
        {
            List<Card> cardsHand;

            if (fromList.CardsInDeck.Count() < cardsToDeal)
            {
                Deck.RandomList(fromList.CardsPlayed);
                fromList.CardsInDeck.AddRange(fromList.CardsPlayed);
                fromList.CardsPlayed.Clear();

                for (int i = 0; i < fromList.CardsPlayed.Count; i++)
                {
                        fromList.CardsPlayed[i].isPrinted = false;
                }
            }

            cardsHand = fromList.CardsInDeck.GetRange(0, cardsToDeal);
            HoldCards.AddRange(cardsHand);
            fromList.CardsInDeck.RemoveRange(0, cardsToDeal);
        }
        
        public int CalculateSum()
        {

            var hand = this.HoldCards;
            var sum = 0;

            for (int i = 0; i < hand.Count(); i++)
            {
                int card = (int)hand[i].Value;
                sum += card;

                if (card == 1)
                {
                    sum += card + 10;
                }
            }

            return sum;
        }



    }

    
}
