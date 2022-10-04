namespace Ch11EX01
{
    public class Chicken : Animal
    {

        public void LayEgg() => Console.WriteLine($"{name} has laid and egg");
        public Chicken(string newName) : base(newName)
        {

        }
    }
}
