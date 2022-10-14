int x, y, j;
for (x = -1; x <= 8; x++)
{
    y = (x - 4) * (x - 4);

    for (j = 0; j < y; j++)
        Console.Write("*");
    Console.WriteLine();
}

