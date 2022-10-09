namespace House
{
    public class door
    {
        protected string color;

        public door()
        {
            color = "Brown";
        }
        public door(string color)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0}.", color);
        }
    }
}



