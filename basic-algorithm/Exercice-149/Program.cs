/*
Write a C# Sharp program to create a new list from a given list of integers removing those values which are less than 4
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_149
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new list from a given list of integers
removing those values which are less than 4");

            Console.WriteLine($"[{String.Join(",",RemoveItems(new List<int>(){0,-2,1,2,3,5,4,7,8}))}]");
            Console.WriteLine($"[{String.Join(",",RemoveItems(new List<int>(){0,-2,1,2,3,5,4,7,8}, less:false))}]");
            Console.WriteLine($"[{String.Join(",",RemoveItems(new List<int>(){10,-2,1,-2,3,5,-4,7,-8},comparator:2, less:false))}]");
        }

        static List<int> RemoveItems(List<int> numbers, int comparator = 4, bool less = true)
        {
            Console.Write($"[{String.Join(",",numbers)}] -> ");

            if(less)
                return numbers.Where(item => item < comparator).ToList();

            return numbers.Where(item => item >= comparator).ToList();
        }
    }
}
