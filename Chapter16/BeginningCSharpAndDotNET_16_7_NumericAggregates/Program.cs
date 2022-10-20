
int[] numbers = GenerateLotsOfNumbers(12045678);

var queryReseul = from n in numbers where n > 1000 select n;

Console.WriteLine("Count of Numbers > 1000");
Console.WriteLine(queryReseul.Count());
Console.WriteLine("Max of Numbers >1000");
Console.WriteLine(queryReseul.Max());
Console.WriteLine("Min of Numbers >1000");
Console.WriteLine(queryReseul.Min());
Console.WriteLine("Average of Numbers>1000");
Console.WriteLine(queryReseul.Average());
Console.WriteLine("Sum of Numbers >1000");
Console.WriteLine(queryReseul.Sum(n => (long)n));
Console.Write("Program finished, press Enter/Return to continue:");



int[] GenerateLotsOfNumbers(int count)
{
    Random generator = new Random(0);
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = generator.Next();
    }
    return result;
}