using Microsoft.EntityFrameworkCore;

namespace Vendors_Report
{
    internal class VendorContex : DbContext
    {

        public DbSet<Vendors> Vendor { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBulider)
        {

            optionsBulider.UseSqlServer(@"Data Source=LJUPCHO;DataBase=Vendor;Integrated Security=True");



        }

    }
}
