/*
Write a C# Sharp program to create a new array taking the elements
    after the element value 5 from a given array of integers
*/
using System;

namespace Exercice_129
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array taking the elements
    after the element value 5 from a given array of integers");

            GetNextFive one = new GetNextFive(new int[]{1,2,3,5,7,9,11});

            Console.WriteLine($"New array: {one}");

        }
    }

    class GetNextFive
    {
        private int[] Old;

        public GetNextFive(int[] numbers)
        {
            Old = numbers;
        }

        public override string ToString()
        {
            return $"[{String.Join(",",Old[(Array.IndexOf(Old, 5)+1)..])}]";
        }
    }
}
