using System.Text.Json;

string jsonWEatherString = File.ReadAllText("../../../Weather.json");

Weather.Weather weather = JsonSerializer.Deserialize<Weather.Weather>(jsonWEatherString);


Console.WriteLine("\t" + nameof(weather.Date) + ": " + weather.Date.ToString());
Console.WriteLine("\t" + nameof(weather.TemperatureCelsius) + ": " + weather.TemperatureCelsius.ToString());
Console.WriteLine("\t" + nameof(weather.Summary) + ": " + weather.Summary.ToString());
Console.Write("\t" + nameof(weather.DatesAvailable) + ": ");
foreach (DateTime datAvail in weather.DatesAvailable)
{
    if (weather.DatesAvailable.Last() == datAvail)
        Console.Write(datAvail.ToString());
    else
        Console.Write(datAvail.ToString() + ", ");
}
Console.WriteLine();
Console.WriteLine("\t" + nameof(weather.TemperatureRanges) + ": ");
Console.WriteLine("\t{");
Console.WriteLine("\t\t" + nameof(weather.TemperatureRanges.Cold) + ": ");
Console.WriteLine("\t\t{");
Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Cold.High) + ": " + weather.TemperatureRanges.Cold.High);
Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Cold.Low) + ": " + weather.TemperatureRanges.Cold.Low);
Console.WriteLine("\t\t}");
Console.WriteLine("\t\t" + nameof(weather.TemperatureRanges.Hot) + ": ");
Console.WriteLine("\t\t{");
Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Hot.High) + ": " + weather.TemperatureRanges.Hot.High);
Console.WriteLine("\t\t\t" + nameof(weather.TemperatureRanges.Hot.Low) + ": " + weather.TemperatureRanges.Hot.Low);
Console.WriteLine("\t\t}");
Console.WriteLine("\t}");
Console.Write("\t" + nameof(weather.SummaryWords) + ": ");
foreach (string word in weather.SummaryWords)
{
    if (weather.SummaryWords.Last() == word)
        Console.Write(word);
    else
        Console.Write(word + ", ");
}
Console.WriteLine();
Console.WriteLine("}");
Console.ReadKey();





