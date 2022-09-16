using System;

namespace exchangingData
{
    internal class Program
    {
        static int val;

        static void ShowDouble()
        {

            val *= 2;
            Console.WriteLine($" val double={val}");
        }
        static void Main(string[] args)
        {
            val = 5;
            Console.WriteLine($" val double={val}");
            ShowDouble();
            Console.WriteLine($" val double={val}");
            Console.ReadLine();

            CustomerName myCustomer;
            myCustomer.firstName = "Ljupcho";
            myCustomer.lastName = "Shemov";
            Console.WriteLine($"{myCustomer.firstName}{myCustomer.lastName}");
        }
            

            struct CustomerName
        {

            public string firstName, lastName;

            public string fullName => $"{firstName}{lastName}";
        }
        }
    }
}
