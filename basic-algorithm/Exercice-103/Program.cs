/*
 Write a C# Sharp program to create an array taking two
    middle elements from a given array of integers of length even
 */
using System;

namespace Exercice_103
{
    class Program
    {
        public static void GetMiddle(int[] numbers)
        {
            int middle = (numbers.Length-1)/2;

            Console.WriteLine($"Original array: {{{String.Join(",", numbers)}}}");
            Console.WriteLine($"Original array: {{{String.Join(",", numbers[middle..(middle+2)])}}}");
        }        
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create an array taking two
    middle elements from a given array of integers of length even");

            GetMiddle(new int[] {1,5,7,9,11,13});
            GetMiddle(new int[] {1,58,66,13});
        }
    }
}