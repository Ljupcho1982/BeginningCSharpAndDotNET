using System.ComponentModel.DataAnnotations;

namespace CreatingDatabase_Code_First
{
    internal class Book
    {

        public string Title { get; set; }

        public string Author { get; set; }

        [Key] public int Code { get; set; }
    }
}
