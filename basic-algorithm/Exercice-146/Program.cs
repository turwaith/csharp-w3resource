/*
Write a C# Sharp program to create a new list of the rightmost digits from a given list of positive integers
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_146
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new list of the rightmost digits from a given list of positive integers");

            Console.WriteLine($"[{String.Join(",",GetRightDigit(new List<int>(){ 10, 22, 35 , 41 }))}]");
            Console.WriteLine($"[{String.Join(",",GetRightDigit(new List<int>(){ 21, 99, 165 , 0 }))}]");
        }

        static List<int> GetRightDigit(List<int> numbers)
        {
            Console.Write($"[{String.Join(",",numbers)}] -> ");
            // cast to String, then get last char and return its numeric value
            // return numbers.Select(item => (int)Char.GetNumericValue(item.ToString()[^1])).ToList();
            return numbers.Select(item => item % 10).ToList();
        }
    }
}
