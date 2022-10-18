using SeriazlizedJSON;
using System.Text.Json;

List<Book> books = new List<Book>();

Book book1 = new Book
{

    title = "Begining C# and .NET",
    author = "Benjamin Perkins and Jon Reid",
    code = "978-1119795780"
};

Book book2 = new Book
{

    title = "Begining XML",
    author = "Joe Fawcett el al",
    code = "978-1118162131"
};

Book book3 = new Book
{

    author = "Profesional C# 7 and .Net Core",
    title = "Christian Nagel",
    code = "978-111944270"
};
books.Add(book1);
books.Add(book2);
books.Add(book3);

string jsonString1 = JsonSerializer.Serialize(books, typeof(List<Book>));
File.WriteAllText("../../../Books.json", jsonString1);
string jsonString2 = File.ReadAllText("Books.json");



List<Book> books2 = JsonSerializer.Deserialize<List<Book>>(jsonString2);
foreach (Book b in books2)
{

    Console.WriteLine("code : {0} title: {1} author: {2}", b.code, b.title, b.author);
}


