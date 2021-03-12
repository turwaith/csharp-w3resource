/*
Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_148
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Remove all ""a"" in each string in given list of strings and return the new string");

            Console.WriteLine($"[{String.Join(",",RemoveChar(new List<string>(){"abc","cdaef","js","php"}))}]");
        }

        static List<string> RemoveChar(List<string> sentences)
        {
            Console.Write($"[{String.Join(",",sentences)}] -> ");
            return sentences.Select(item => item.Replace('a','\0').Trim()).ToList();
        }
    }
}
