namespace House
{
    public class Person
    {

        protected string name;
        protected house house;

        public Person()
        {
            name = "Juan";
            house = new house(150);
        }
        public Person(string name, house house)
        {
            this.name = name;
            this.house = house;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public house House
        {
            get { return house; }
            set { house = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("My name is {0}.", name);
            house.ShowData();
            house.Door.ShowData();
        }


    }
}
