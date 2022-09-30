using CH10CardLib;

namespace Ch10CardLib
{
    public class Card
    {
        public Rank rank;
        public Suit suit;

        private Card() { }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString() => "The " + rank + " of " + suit + "s";
    }
}
