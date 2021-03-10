/*
Write a C# Sharp program to create a new list from a given list of
    strings where each element has "#" added at the beginning and end position
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_143
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new list from a given list of strings where each
    element has ""#"" added at the beginning and end position");

            Console.WriteLine($"[{String.Join(",",ChangeItem(new List<string>(){ "1", "2", "3" , "4" }))}]");
        }

        static List<string> ChangeItem(List<string> sentences, char sep = '#')
        {
            Console.Write($"[{String.Join(",",sentences)}] -> ");
            return sentences.Select(item => sep+item+sep).ToList();
        }
    }
}
