﻿
Console.WriteLine("Enter a word:");

string input = Console.ReadLine();

string output = "";

for (int i = input.Length - 1; i >= 0; i--)
{
    output += input[i];
}

Console.WriteLine(output);