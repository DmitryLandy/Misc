using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); //create deck, calls constructor

            //print each card in the deck
            foreach (var item in deck.deck)
            {
                Console.WriteLine(item);
            }
        }
    }
    

    enum CardSuits { clubs, hearts, diamonds, spades }
    enum CardValues { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }

    internal class Deck
    {
        public List<Card> deck { get; }
        const int deckSize = 52;
        const int valueSize = 13;
        const int suitSize = 4;

        public Deck()
        {
            deck = new List<Card>();

            for (int deckIndex = 0; deckIndex < deckSize; deckIndex++)
            {
                int cardValue = deckIndex % valueSize;
                int suit = deckIndex % suitSize;
                deck.Add(new Card((CardSuits)suit, (CardValues)cardValue));
            }
        }
    }


    internal class Card
    {        

        public CardSuits suit { get; set; }
        public CardValues value { get; set; }        

        public Card(CardSuits suitValue, CardValues cardValue)
        {
            suit = suitValue;
            value = cardValue;
        }

        public override string ToString()
        {
            return $"{value} of {suit}";
        }
    }
}
