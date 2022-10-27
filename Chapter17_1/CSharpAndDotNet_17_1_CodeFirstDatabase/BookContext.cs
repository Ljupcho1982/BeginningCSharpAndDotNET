using Microsoft.EntityFrameworkCore;

namespace CSharpAndDotNet_17_1_CodeFirstDatabase
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Store> Store { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            optionsBuilder.UseSqlServer(@"Data Source=LJUPCHO;Database=Books;Integrated Security=True");
        }
    }
}
