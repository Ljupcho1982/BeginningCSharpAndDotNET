using System;

namespace Objects
{
    internal partial class Program
    {
        public class Chicken: Animal
        {

            public Chicken() : base()
            {

            }
            public Chicken(string name, int age):base(name,age)
            {

            }
            public void Cluck()
            {
                Console.WriteLine($"{Name} is Clucking!");

            }

            public void LayEgg()
            {
                Console.WriteLine($"{Name} is laying eggs!");

            }
        }
    }
}




    
