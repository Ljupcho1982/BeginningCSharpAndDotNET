namespace CardLib
{
    public class Card
    {
        public readonly Rank rank;
        public readonly Suit suit;



        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;

        }

        private Card() { }

        public override string ToString() => "The " + rank + "of" + suit + "s";


    }
}