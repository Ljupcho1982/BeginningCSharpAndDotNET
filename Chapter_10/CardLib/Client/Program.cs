using CardLib;

Deck myDeck = new Deck();
myDeck.Shuffle();
int j = 0;
while (j < 1)
{



    for (int i = 0; i < 5; i++)
    {
        Random rand = new Random();

        var five = rand.Next(4);

        Card tempCard = myDeck.GetCard(five);

        Console.WriteLine(tempCard);


        var tempIndex = (int)tempCard.suit;


        Console.WriteLine(tempCard.suit);

        Console.WriteLine(tempIndex);

        if (tempIndex.Equals(tempCard.suit))
        {

            Console.WriteLine("Flush");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }
        j++;





    }








    //if (i != 51)
    //    Console.Write(",\n");
    //else
    //    Console.WriteLine();
}
Console.ReadKey();

{

}



