﻿string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilych", "Singh", "Samba", "Fatima" };

var querryResults = from n in names where n.StartsWith("S") select n;

Console.WriteLine("Names beginning with S: ");

foreach (var item in querryResults)
{
    Console.WriteLine(item);
    // Console.WriteLine($"Orderby in descending order {item.Reverse()}");
}


var commaSeperatedString = querryResults.Aggregate((s1, s2) => s1 + ", " + s2);
Console.WriteLine("Aggregate : " + commaSeperatedString);

Console.WriteLine("-----------Orderby in descending order------------");
foreach (var item in querryResults.Reverse())
{

    Console.WriteLine(item);
}


Console.Write("Program finished, press Enter/Return to continue: ");

IEnumerable<string> methodQuery = names.Where(n => n.StartsWith("S"));


