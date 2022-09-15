using System;
using System.Runtime.Intrinsics.Arm;

namespace Ch06Ex01
{
    internal class Program
    {

        static void Write()
        {

            Console.WriteLine("Text output from function.");
        }
        static void Main(string[] args)
        {
           Write();
           Console.ReadLine();

        }
    }
}
