using System;

namespace DeckofCards
{
    public class Card
    {
        private string stringVal;
        public string StringVal
        {
            get{return stringVal;}
        }
        private string suit;
        private int val;

        public Card(string newStringVal, string newSuit, int newVal)
        {
            stringVal = newStringVal;
            suit = newSuit;
            val = newVal;
            
            Console.WriteLine("hello from Card.cs");
        }

        public void Print()
        {
            Console.WriteLine($"{stringVal} of {suit}: {val}");
        }
    }    
}