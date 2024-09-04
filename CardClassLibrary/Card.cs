using System;

namespace CardClassLibrary
{
    public enum Suit {Empty, Hearts, Spades, Clubs, Diamonds }
    public class Card : IComparable, IComparable<Card>
    {
        public Suit Suit { get; set; }
        public int Value { get; set; }

        public Card(int value, Suit suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }

        public int CompareTo(Card other)
        {
            return Value.CompareTo(other.Value);
        }

        public int CompareTo(object obj)
        {
            if ( obj ! is Card) { throw new ArgumentException("That wasn't a card"); }
            return CompareTo((Card)obj);    
        }
    }
}
