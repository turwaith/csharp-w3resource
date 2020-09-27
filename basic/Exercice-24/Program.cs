/*
Write a C# program to find the longest word in a string.
Test Data: 
    Write a C# Sharp Program to display the following pattern using the alphabet.
Sample Output:
f   ollowing
*/
using System;

namespace Exercice_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataString = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] dataWords = dataString.Split(" ");
            string longestWord = String.Empty;
            int size = 0;

            foreach(string item in dataWords)
            {
                if(item.Length > size)
                {
                    size = item.Length;
                    longestWord = item;
                }
            }

            Console.WriteLine(dataString);
            Console.WriteLine($"Longest word: {longestWord}");
        }
    }
}
