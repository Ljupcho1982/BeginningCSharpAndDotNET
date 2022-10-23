using Microsoft.EntityFrameworkCore;

namespace vendor123
{
    public class VendorContex : DbContext
    {

        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Database = vendor1; Integrated Security=True");

        }
    }
}

