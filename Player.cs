using System;
using System.Collections.Generic;

namespace DeckofCards
{
    public class Player
    {
        public List<Card> Hand;
        public string Name;

        public Player()
        {
            Hand = new List<Card>();
            
        }
        
        
        public Card DrawCard(Deck SomeDeck)
        {
            // draw a card from deck
            Card getCard = SomeDeck.cards[0];
            //put in hand
            Hand.Add(getCard);
            //return card to hand
            return getCard;
        }

        public Card Discard(int num)
        {
            Card discard;
            if(num < Hand.Count)
            {
                discard = Hand[num];
                Hand.RemoveAt(num);
                return discard;
            }
            else
            {
                return null;
            }
        }

    }
}