string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small",
"Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };

var result = from n in names where n.StartsWith("S") orderby n.Length select n;

foreach (var name in result)
{

    Console.WriteLine(name);
}


IEnumerable<string> result1 = names.Where(n => n.StartsWith("S")).OrderBy(n => n.Length);

foreach (var name in result1)
{
    Console.WriteLine(name);
}