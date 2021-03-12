/*
Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercice_150
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new list from a given list of integers removing those values end with 7");
            
            Console.WriteLine($"[{String.Join(",",RemoveIfEndWith(new List<int>(){10,22,35,47,53,67}))}]");
            Console.WriteLine($"[{String.Join(",",RemoveIfEndWith(new List<int>(){10,22,35,47,53,67}, 2))}]");
        }

        static List<int> RemoveIfEndWith(List<int> numbers, int comparator = 7)
        {
            Console.Write($"[{String.Join(",",numbers)}] -> ");
            return numbers.Where(item => item % 10 != comparator).ToList();
        }
    }
}
