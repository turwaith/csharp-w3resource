/*
Write a C# Sharp program to find out the maximum element between
    the first or last element in a given array of integers
    ( length 4), replace all elements with maximum element
*/
using System;
using System.Linq;

namespace Exercice_94
{
    class Program
    {
        public static int[] GetSetMax(int[] numbers)
        {
            return Enumerable.Repeat(numbers.Max(), numbers.Length).ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Find out the maximum element between
    the first or last element in a given array of integers
    ( length 4), replace all elements with maximum element");

            Console.WriteLine($"{{{String.Join(",",GetSetMax(new int[]{10,20,-30,-40}))}}}");
            Console.WriteLine($"{{{String.Join(",",GetSetMax(new int[]{1,20,69,-780}))}}}");
        }
    }
}
