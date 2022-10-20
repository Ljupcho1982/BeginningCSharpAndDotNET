
using BeginningCSharpAndDotNET_16_4_PersonObject;
List<Person> people = new List<Person>()
{
    new Person() { FirstName = "Alonso", LastName = "Sherman", Age = 23},
    new Person() { FirstName = "Smith", LastName = "Howells", Age = 16},
    new Person() { FirstName = "Smythe", LastName = "Warner", Age = 32},
    new Person() { FirstName = "Ilyich", LastName = "King", Age = 64},
    new Person() { FirstName = "Jones", LastName = "Bright", Age = 26},
    new Person() { FirstName = "Smith", LastName = "Walton", Age = 45},
    new Person() { FirstName = "Samba", LastName = "Warren", Age = 25},
    new Person() { FirstName = "Singh", LastName = "Flynn", Age = 18},
    new Person() { FirstName = "Fatimah", LastName = "Torres", Age = 10},
    new Person() { FirstName = "Zheng", LastName = "Chen", Age = 53},
    new Person() { FirstName = "Ruiz", LastName = "Flowers", Age = 33},
    new Person() { FirstName = "Jorgenson", LastName = "Frank", Age = 37},
    new Person() { FirstName = "Hsieh", LastName = "Howells", Age = 21}
};


//LINQ query for filtering lastName that starts with "F"
var querryResults = from person in people where person.LastName.StartsWith("F") select person;

Console.WriteLine("LastName beginning with F: ");

foreach (var item in querryResults)
{
    Console.WriteLine($" {item.FirstName} {item.LastName} has age of {item.Age}");

}

IEnumerable<Person> methodQuery = people.Where(p => p.LastName.StartsWith("F"));


foreach (var item in methodQuery)
{

    Console.WriteLine($"{item.LastName}");
}

IEnumerable<Person> methodQuery1 = people.Where(p => p.Age >= 21);

foreach (var item in methodQuery1)
{

    Console.WriteLine($"{item.Age}");
}

var age = from Person in people where Person.Age >= 21 select Person;

foreach (var item in age)
{

    Console.WriteLine(item);
}