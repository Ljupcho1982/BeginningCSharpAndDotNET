string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilych", "Singh", "Samba", "Fatima" };
var queryResults = names.Where(n => n.StartsWith("S"));

Console.WriteLine("Names beginning with S: ");
foreach (var item in queryResults)
{

    Console.WriteLine(item);
}

Console.WriteLine("Program finished, press Enter/Return to continue: ");

