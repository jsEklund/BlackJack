using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        /*
        public deck()
        {
            this.cards = this.addDescks(1);
        }
        */
        public List<Card> CardsInDeck = new List<Card>();

        

        public void AddDecks(int decks)
        {

            for (int i = 0; i < decks; i++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {

                    foreach (Value value in Enum.GetValues(typeof(Value)))
                    {

                        CardsInDeck.Add(new Card()
                        {
                            Suit = (Suit)suit,
                            Value = (Value)value
                        });

                    };
                }
            }

            //cards = randomList(cardList);
        }

        public static Tuple<int, bool> CalculateCards(List<Card> hand)
        {
            int sumHand = 0;
            bool softHand = false;

            for (int i = 0; i < hand.Count; i++)
            {
                sumHand += Card.CheckCardValue(hand[i]);

                if (hand[i].Value == Value.Ace)
                {
                    softHand = true;
                }
            }
            return new Tuple<int, bool>(sumHand, softHand);
        }
        protected static List<Card> RandomList(List<Card> cardList)
        {
            var randomGenerator = new Random();
            var result = cardList.OrderBy(item => randomGenerator.Next());

            return result.ToList();
        }

        public List<Card> InGameCards = new List<Card>();
        
        // public List<card> playedCards = new List<card>();


        public List<Card> TakeCards(int cardsToTake = 1)
        {
            // TODO: Check if CardsInDeck running out of cards If,  reschuffle used cards

            List<Card> TakenCards = new List<Card>();
            TakenCards = CardsInDeck.GetRange(0, cardsToTake);
            CardsInDeck.RemoveRange(0, cardsToTake);

            return TakenCards;
        }


    }



}
