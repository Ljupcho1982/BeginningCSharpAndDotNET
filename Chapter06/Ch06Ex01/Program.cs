using System;
using System.Runtime.Intrinsics.Arm;

namespace Ch06Ex01
{
    internal class Program
    {
        static string myString;
        static void Write()
        {
            string myString = "String defined in Write()";
            Console.WriteLine("Now in Write()");
            Console.WriteLine($"myString={myString}");
            Console.WriteLine($"Local myString={myString}");
            Console.WriteLine($"Global myString={Program.myString}");
        }
        static void Main(string[] args)
        {
        string myString = "String defined in Main()";
            Program.myString = "Global variable";
        Write();
            Console.WriteLine("\nNow in Main ()");
            Console.WriteLine($"Local myString={myString}");
            Console.WriteLine($"Global myString={Program.myString}");

           
            string text=default;
            for (int i = 0; i < 10; i++)
            {

                 text = $"Line {Convert.ToString(i)}";
                Console.WriteLine(text);

            }
            string insideIf = "";
            if (true)
            {

                 insideIf = "ok";
            }
            

            Console.WriteLine($"Last text:{text}");
            Console.WriteLine($"InsideIf:{insideIf}");
            Console.ReadLine();

        }
    }
}
