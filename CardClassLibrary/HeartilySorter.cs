using System.Collections.Generic;

namespace CardClassLibrary
{
    public class HeartilySorter : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            int xValue = GetValue(x);
            int yValue = GetValue(y);
            return xValue.CompareTo(yValue);
        }

        private int GetValue(Card card)
        {
            int value = card.Value;
            if (card.Suit == Suit.Hearts) { value += 13; }
            return value;
        }
    }
}