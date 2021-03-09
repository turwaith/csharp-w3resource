/*
Write a C# Sharp program to create a new list from a given
    list of integers where each integer multiplied by itself three times
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_142
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new list from a given list of integers
    where each integer multiplied by itself three times");

            Console.WriteLine($"[{String.Join(",",GetNewList(new List<int>(){ 1, 2, 3 , 4 }))}]");
        }

        static List<int> GetNewList(List<int> numbers)
        {
            Console.Write($"[{String.Join(",",numbers)}] -> ");

            return numbers.Select(item => (int)Math.Pow(item,3)).ToList();
        }
    }
}
