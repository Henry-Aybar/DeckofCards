using System;
using System.Collections.Generic;

namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Card testCard = new Card("Ace", "Spades", 1);
            // testCard.Print();
            // Console.WriteLine(testCard.StringVal);


            Deck simpleDeck = new Deck();
            simpleDeck.Shuffle();
            simpleDeck.PrintDeck();

            Player player = new Player();
            player.DrawCard(simpleDeck);
        }
    }
}
