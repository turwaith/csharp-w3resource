/*
Write a C# Sharp program to create a new list from a given list of strings where each
element is replaced by 4 copies of the string concatenated together
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_144
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new list from a given list of strings where each
element is replaced by 4 copies of the string concatenated together");

            Console.WriteLine($"[{String.Join(",",RepeatItem(new List<string>(){"1","2","3","4"}))}]");
        }

        static List<string> RepeatItem(List<string> sentences, int times = 4)
        {
            Console.Write($"[{String.Join(",",sentences)}] -> ");
            return sentences.Select(item => new string(item[0],times)).ToList();
        }
    }
}
