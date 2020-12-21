/*
Write a C# Sharp program to reverse a given array of integers and length 5
*/
using System;

namespace Exercice_93
{
    class Program
    {
        public static int[] GetReversedArray(int[] numbers)
        {
            Array.Reverse(numbers);
            return numbers;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse a given array of integers and length 5");

            Console.WriteLine($"{{{String.Join(",",GetReversedArray(new int[]{ 10, 20, -30, -40, 50 }))}}}");
        }
    }
}
