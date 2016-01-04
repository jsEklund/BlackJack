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
        /*private Hand myHand;*/

      //  public int Sum;
        

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

            Sum(cardsHand);
        }
        
        /*
        public bool IsSoftHand()
        {
            var softHand = false;
            var hand = this.HoldCards;

            for (int i = 0; i < hand.Count(); i++)
            {

            }
                return true;
        }     
        */
            
        public int Sum(List<Card> hand)
        {
            var thisHand = hand;
            var totalSum = 0;

            for (int i = 0; i < thisHand.Count(); i++)
            {
                totalSum += (int)thisHand[i].Value;
            }

            return totalSum;
        }

        public int Sum()
        {
            return Sum(HoldCards);
        }

        public bool IsBusted()
        {
            if (Sum() > 21)
            {
                return true;
            }

            return false;
        }

        public bool IsBlackjack()
        {
            if (Sum(HoldCards) == 21 && HoldCards.Count() == 2)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
