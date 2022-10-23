using CreatingDatabase_Code_First;

using (var db = new BookContext())
{
    Book book1 = new Book() { Title = "Begining with C# and .Net 6", Author = "Perkins and Reid " };

    db.Books.Add(book1);
    db.SaveChanges();
    Book book2 = new Book() { Title = "Beging XML", Author = "Fawcet, Quin and Ayers " };
    db.Books.Add(book2);
    db.SaveChanges();

    var querry = from b in db.Books orderby b.Title select b;

    Console.WriteLine("All the books in databes ");

    foreach (var item in querry)
    {

        Console.WriteLine($" tile={item.Title} Author={item.Author} Code={item.Code}");
    }
}

