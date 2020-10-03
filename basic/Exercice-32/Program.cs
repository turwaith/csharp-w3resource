/*
Write a C# program to create a new string of four copies, taking last four characters from a given string.
If the length of the given string is less than 4 return the original one. 
Sample Output:
    Input a string : The quick brown fox jumps over the lazy dog.
    dog.dog.dog.dog.
*/
using System;

namespace Exercice_32
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;

            Console.Write("Input a string: ");
            userInput = Console.ReadLine();

            Console.WriteLine(userInput.Length < 4 ? 
                                userInput+userInput+userInput+userInput :
                                userInput[^4..^0]+userInput[^4..^0]+userInput[^4..^0]+userInput[^4..^0]);         
        }
    }
}
