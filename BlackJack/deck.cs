using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {

        public List<Card> CardsInDeck = new List<Card>();
        public List<Card> CardsPlayed = new List<Card>();

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
        internal static List<Card> RandomList(List<Card> cardList)
        {
            var randomGenerator = new Random();
            var result = cardList.OrderBy(item => randomGenerator.Next());

            return result.ToList();
        }

        

    }
}
