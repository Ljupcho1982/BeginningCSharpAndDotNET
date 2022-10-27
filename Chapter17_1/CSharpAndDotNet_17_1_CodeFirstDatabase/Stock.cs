using System.ComponentModel.DataAnnotations;

namespace CSharpAndDotNet_17_1_CodeFirstDatabase
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }

        public int OnHand { get; set; }

        public int OnOrder { get; set; }

        public virtual Book Item { get; set; }

    }
}
