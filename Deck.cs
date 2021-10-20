using System;
using System.Collections.Generic;

namespace DeckofCards
{
    public class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            // Console.WriteLine("hello fron Deck Class!");
            cards = new List<Card>();
            populateDeck();
        }

        private void populateDeck()
        {
            //loop though array of all 4 suits
                //loop though 1-13
                    // new card with suit and value
            string[] suits = {"Spades","Dimonds","Hearts","Clubs"};

            foreach(string suit in suits)
            {
                for(int i=1; i < 14; i++)
                {
                    // Console.WriteLine($"{i} of {suit}");
                    string stringVal;

                    if(i > 1 && i < 11)
                    {
                        stringVal = i.ToString();
                    }
                    else if(i == 1)
                    {
                        stringVal = "Ace";
                    }
                    else if(i == 11)
                    {
                        stringVal = "Jack";
                    }
                    else if(i == 12)
                    {
                        stringVal = "Queen";
                    }
                    else
                    {
                        stringVal = "King";
                    }

                    cards.Add(new Card(stringVal, suit, i));
                }
            }
        }
        public void Shuffle()
        {
            for (int i=0; i < cards.Count; i++ )
            {
                Random rand = new Random();
                rand.Next(cards.Count);
                int randomIndex = rand.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
                
            }
        }

        public Card Draw()
        {
            Card returnMe = cards[0];
            cards.RemoveAt(0);
            return returnMe;
        }
        public void PrintDeck()
        {
            foreach(Card card in cards)
            {
                card.Print();
            }
        }
    }
    
}