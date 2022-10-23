using Microsoft.EntityFrameworkCore;

namespace Vendors1
{
    public class Vendors1Context : DbContext
    {

        public DbSet<Vendors> vendors1s { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LJUPCHO;Database=Vendor;Integrated Security=True"); ;

        }
    }
}
