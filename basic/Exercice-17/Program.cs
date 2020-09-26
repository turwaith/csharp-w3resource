/*
Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
Sample Output:
    Input a string : The quick brown fox jumps over the lazy dog.
    TThe quick brown fox jumps over the lazy dog.T
*/
using System;

namespace Exercice_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   userWord = String.Empty;;
            char firstChar; 

            Console.Write("Input a string: ");
            userInput = Console.ReadLine();

            firstChar = userInput[0];

            userWord += firstChar;
            userWord += userInput;
            userWord += firstChar;

            Console.WriteLine(userWord);
        }
    }
}
