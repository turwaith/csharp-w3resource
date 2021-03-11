/*
Write a C# Sharp program to create a new list from a given list of integers where each
    integer value is added to 2 and the result value is multiplied by 5
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_145
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new list from a given list of integers where each
integer value is added to 2 and the result value is multiplied by 5");

            Console.WriteLine($"[{String.Join(",",Multiply(new List<int>(){1,2,3,4}))}]");
        }

        static List<int> Multiply(List<int> numbers, int multiplier = 5)
        {
            Console.Write($"[{String.Join(",",numbers)}] -> ");
            return numbers.Select(item => (item + 2) * multiplier).ToList();
        }
    }
}
