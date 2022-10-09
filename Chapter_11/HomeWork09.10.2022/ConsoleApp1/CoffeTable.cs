namespace ConsoleApp1
{
    public class CoffeTable : Table
    {
        public CoffeTable(int width, int height) : base(width, height)
        {

            this.width = width;
            this.height = height;
        }

        public int coffeTablewidth { get; set; }
        public int coffeTableheight { get; set; }

        public override void ShowData()
        {

            Console.WriteLine("(CoffeTable) Width {0} Height {1}", width, height);
        }


    }


}
