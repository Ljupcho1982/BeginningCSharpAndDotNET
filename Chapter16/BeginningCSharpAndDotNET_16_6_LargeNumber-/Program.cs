
int[] numbers = GenerateLotsOfNumbers(12045678);



var query = from n in numbers where n < 1000 orderby n select n;

Console.WriteLine();

//foreach (var n in query)
//{

//	Console.WriteLine(n);
//	Console.WriteLine(Convert.ToInt64(n));

//}

Console.WriteLine("----Numbers lager than 1000");
var queryLarge = numbers.Where(n => n > 1000);


foreach (var n in queryLarge)
{

	Console.WriteLine(n);
}

int[] GenerateLotsOfNumbers(int lenght)
{
	Random random = new Random();
	int[] numbers = new int[lenght];
	for (int i = 0; i < lenght; i++)
	{
		numbers[i] = random.Next(0, lenght);

	}

	return numbers;

}