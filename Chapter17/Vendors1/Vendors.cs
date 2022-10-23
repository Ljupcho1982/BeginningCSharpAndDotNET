using System.ComponentModel.DataAnnotations;

namespace Vendors1
{
    public class Vendors
    {

        public string Name { get; set; }

        public int Id { get; set; }

        public string Product { get; set; }

        public int number_Sales { get; set; }

        public decimal Price { get; set; }

        [Key] public int Code { get; set; }

    }
}
