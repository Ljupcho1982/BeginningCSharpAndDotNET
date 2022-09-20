namespace Objects
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken("Marko", 2);
            chicken.Age += 1;

            chicken.EatFood();
            chicken.Cluck();

            Chicken chicken1 = new Chicken();
            chicken1.Name = "Goran";
            chicken1.Age = 1;

            chicken1.EatFood();
            chicken1.Cluck();

            Cow cow= new Cow("Milka",12);

            cow.EatFood();
            cow.Moo();

            Animal newChicken = new Chicken("Iva", 2);
            newChicken.EatFood();

            IAnimal newChicken1 = new Chicken();
            newChicken1.Name = "Dina";
            newChicken1.Age = 1;

            newChicken1.EatFood();  


            
        }
    }
}




    
