/*
Write a C# Sharp program to create a new array taking the first and
    last elements of a given array of integers and length 1 or more
*/
using System;

namespace Exercice_96
{
    class Program
    {
        public static int[] GetNewArray(int[] numbers)
        {
            return new int[] {numbers[0], numbers[^1]};
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array taking the first and
    last elements of a given array of integers and length 1 or more");

            Console.WriteLine(String.Join(",",GetNewArray(new int[] {10,20,-30,-40,30})));
        }
    }
}
