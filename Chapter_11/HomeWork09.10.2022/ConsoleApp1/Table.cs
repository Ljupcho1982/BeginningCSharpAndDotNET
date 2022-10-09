namespace ConsoleApp1
{
    public class Table
    {
        private int v1;
        private int v2;

        public int width { get; set; }

        public int height { get; set; }


        public Table(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Table(int width, int height, int v1, int v2) : this(width, height)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public virtual void ShowData()
        {

            Console.WriteLine($"The height of the board is {height} and width of the board is {width}");
        }
    }
}
