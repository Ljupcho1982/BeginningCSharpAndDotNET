using System.ComponentModel.DataAnnotations;

namespace Vendors_Report
{
    internal class Vendors
    {

        public string Vendor_Name { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public int NumberOfSoldProducts { get; set; }

        [Key] public int Code { get; set; }
    }
}
