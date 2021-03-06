/*
Write a C# Sharp program to create a new array from a given array of strings
    using all the strings whose length are matched with given string length
*/
using System;
using System.Linq;

namespace Exercice_138
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array from a given array of strings
    using all the strings whose length are matched with given string length");

            Console.WriteLine(String.Join(",",GetNewArray(new string[]{"a", "aaa", "b", "bbb", "c", "ccc" }, 3)));
        }

        static string GetNewArray(string[] sentences, int size)
        {
            string[] output = sentences.Where(item => item.Length == size).ToArray();

            Console.Write($"[{String.Join(",",sentences)}], ({size}) -> ");

            return $"[{String.Join(",",output)}]";
        }
    }
}
