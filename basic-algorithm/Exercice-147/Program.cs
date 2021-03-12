/*
Write a C# Sharp program to create a new list from a given list of
    strings where strings will be in upper case in new string
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_147
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new list from a given list of
strings where strings will be in upper case in new string");

            Console.WriteLine($"[{String.Join(",",UpperCase(new List<string>(){"Abc","cdef","js","php"}))}]");
        }

        static List<string> UpperCase(List<string> sentences)
        {
            Console.Write($"[{String.Join(",",sentences)}] -> ");
            return sentences.Select(item => item.ToUpper()).ToList();
        }
    }
}
