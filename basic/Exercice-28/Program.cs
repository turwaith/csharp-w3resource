/*
Write a C# program to reverse the words of a sentence. Go to the editor
Sample Output:
    Original String: Display the pattern like pyramid using the alphabet.
    Reverse String: alphabet. the using pyramid like pattern the Display
*/
using System;

namespace Exercice_28
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            string[] stringWords;

            Console.WriteLine("Reverse the words of a sentence.");
            
            Console.Write("Original String > ");
            userInput = Console.ReadLine();

            stringWords = userInput.Split(" ");
            Array.Reverse(stringWords);

            Console.WriteLine($"Reverse String  > {string.Join(" ",stringWords)}");
        }
    }
}
