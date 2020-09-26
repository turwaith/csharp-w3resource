/*
Write a C# program remove specified a character from a non-empty string using index of a character.
Test Data:
    w3resource
Sample Output:
    wresource
    w3resourc
    3resource
*/
using System;

namespace Exercice_15
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = "w3resource",
                   newWord = String.Empty;
            ConsoleKeyInfo userInput;
            int charIndex;

            Console.Write($"Enter a character to remove from {word}: ");
            userInput = Console.ReadKey();
            
            newWord =  word;            
            while(true)
            {
                charIndex = newWord.IndexOf(userInput.KeyChar);
                if(charIndex < 0) break;
                else newWord = newWord.Remove(charIndex,1);
            }
            

            Console.WriteLine();
            Console.WriteLine(word);
            Console.WriteLine(newWord);
        }
    }
}
