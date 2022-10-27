using System.ComponentModel.DataAnnotations;

namespace CSharpAndDotNet_17_1_CodeFirstDatabase
{
    public class Store
    {
        [Key]
        public int StoreID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public virtual List<Stock> Inventory { get; set; }
    }
}
