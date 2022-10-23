using Microsoft.EntityFrameworkCore;

namespace CreatingDatabase_Code_First
{
    internal class BookContext : DbContext

    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Database=Books;Integrated Security=True");


        }

    }
}
