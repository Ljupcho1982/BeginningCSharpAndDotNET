using System;

namespace CH06Ex03
{
    internal class Program
    {

        static int SumVal(params int[] vals)
        {

            int sum = 0;
            foreach(int val in vals)
            {

                sum += val;
            }
        return sum;

        }
        static void Main(string[] args)
        {

            int[] vals=new int[] { 1, 5, 2, 9, 8};
            int sum1 = SumVal(vals);
            Console.WriteLine($"Summed Values={sum1}");
            Console.ReadLine();

            int[] arr=new int[]{ 1, 5, 2, 9, 8};
            int[] arr1 = arr;
            arr1[0] = 5;


            foreach(var item in arr1)
            {

                Console.WriteLine(item);
            }


            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };

            Console.WriteLine($"The maximum value in myArray is {MaxValue(myArray, out int maxIndex)}");
            Console.WriteLine($"The first occurence of this value is at element{maxIndex+1}");
        }

        static int MaxValue(int[] intArray, out int maxIndex)
        {

            int maxVal=intArray[0];
            maxIndex = 0;
            for(int i=1; i < intArray.Length; i++)
            {

                if(intArray[i] > maxVal)
                {
                    maxVal= intArray[i];
                    maxIndex = i;
                }
            }

            return maxVal;

        }
        
    }
    
}
