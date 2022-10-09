namespace House
{
    public class house
    {
        protected int area;
        protected door door;

        public house(int area)
        {
            this.area = area;
            door = new door();

        }
        public int Area
        {
            get { return area; }
            set { area = value; }
        }
        public door Door
        {
            get { return door; }
            set { door = value; }
        }

        public virtual void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2.", area);
        }
    }


}
