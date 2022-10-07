using System.Collections;

namespace Ch11CardLib2
{
    public class CardCollection : CollectionBase, ICloneable

    {
        public void Add(Card newCard) => List.Add(newCard);
        public void Remove(Card oldCard) => List.Remove(oldCard);

        public Card this[int cardIndex]
        {

            get { return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
        }

        /// <summary>
        /// Utility method for copying card instances into another CardCollection
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        /// 
        public void CopyTo(CardCollection targetCards)
        {

            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        public bool Contains(Card card) => InnerList.Contains(card);

        public object Clone()
        {
            CardCollection newCardCollection = new CardCollection();

            foreach (Card sourceCard in List)
            {

                newCardCollection.Add(sourceCard);
            }

            return newCardCollection;

        }
    }
}
