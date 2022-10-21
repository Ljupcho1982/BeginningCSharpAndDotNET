using Microsoft.EntityFrameworkCore;

namespace BeginningCSharpAndDotNet_17_1_CodeFirstDatabase
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Database=Books;Integrated Security=True");

        }
    }
}
