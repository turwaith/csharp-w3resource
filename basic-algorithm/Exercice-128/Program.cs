/*
Write a C# Sharp program to create a new array taking the elements
    before the element value 5 from a given array of integers
*/
using System;

namespace Exercice_128
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"create a new array taking the elements
    before the element value 5 from a given array of integers");

            int[] test = { 1, 2, 3, 5, 7 };

            Console.WriteLine($"({String.Join(",",test)}) => ({String.Join(",",test.GetBefore(5))})");
        }
    }
    
    static class Extension{
        public static int[] GetBefore(this int[] numbers, int number)
        {
            int index = Array.IndexOf(numbers, number);
            return numbers[0..index];
        }
    }
}
