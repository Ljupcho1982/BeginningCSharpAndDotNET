
Console.WriteLine("Enter a symbol:");
int symbol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a width");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a height");
int height = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < width; i++)
{

	for (int j = 0; j < height; j++)
	{
		Console.Write(symbol);
	}

	Console.WriteLine(symbol);
}
