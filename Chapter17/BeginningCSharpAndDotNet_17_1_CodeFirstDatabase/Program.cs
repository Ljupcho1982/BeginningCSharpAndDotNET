using BeginningCSharpAndDotNet_17_1_CodeFirstDatabase;
using static System.Console;

using (var db = new BookContext())
{
    Book book1 = new Book { Title = "Beginning C# and .NET", Author = "Perkins and Reid" };
    db.Books.Add(book1);
    Book book2 = new Book { Title = "Beginning XML", Author = "Fawcett, Quin, and Ayers" };
    db.Books.Add(book2);
    db.SaveChanges();
    var query = from b in db.Books
                orderby b.Title
                select b;
    WriteLine("All books in the database:");
    foreach (var b in query)
    {
        WriteLine($"{b.Title} by {b.Author}, code={b.Code}");
    }
    WriteLine("Press a key to exit...");
    ReadKey();
}