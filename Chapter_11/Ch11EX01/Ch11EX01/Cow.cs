namespace Ch11EX01
{
    public class Cow : Animal

    {
        public Cow(string newName) : base(newName)
        {


        }

        public void Milk() => Console.WriteLine($"{name} has been milked");
    }
}
