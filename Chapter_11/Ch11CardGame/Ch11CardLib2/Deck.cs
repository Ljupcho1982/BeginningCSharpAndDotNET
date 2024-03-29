﻿using Ch11CardLib2;

namespace CardLib

    public class Deck : ICloneable
{



{
    private CardCollection cards = new CardCollection();
    public Deck()
    {
        // Line of code removed here
        for (int suitVal = 0; suitVal < 4; suitVal++)
        {
            for (int rankVal = 1; rankVal < 14; rankVal++)
            {
                cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
            }
        }
    }

    public object Clone()
    {
        Deck newDeck = new Deck(cards.Clone() as CardCollection);

    }

    private Deck(CardCollection newCard) => cards = newCard;

    private CardCollection cards = new CardCollection();

    public Card GetCard(int cardNum)
    {
        if (cardNum >= 0 && cardNum <= 51)
            return cards[cardNum];
        else
            throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
            "Value must be between 0 and 51."));
    }
    public void Shuffle()
    {
        CardCollection newDeck = new CardCollection();
        bool[] assigned = new bool[52];
        Random sourceGen = new Random();
        for (int i = 0; i < 52; i++)
        {
            int sourceCard = 0;
            bool foundCard = false;
            while (foundCard == false)
            {
                sourceCard = sourceGen.Next(52);
                if (assigned[sourceCard] == false)
                    foundCard = true;
            }
            assigned[sourceCard] = true;
            newDeck.Add(cards[sourceCard]);
        }
        newDeck.CopyTo(cards);
    }
}
}