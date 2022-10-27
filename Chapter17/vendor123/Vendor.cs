using System.ComponentModel.DataAnnotations;

namespace vendor123
{
    public class Vendor
    {

        public string Name { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }

        public int Number_product { get; set; }

        [Key] public int Code { get; set; }

        public decimal Sum
        {
            get ; 


            set { this.Sum = this.Number_product * this.Price; }





        }
    }
};


