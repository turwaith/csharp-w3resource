/*
Write a C# Sharp program that takes a character as input and check the input
    (lowercase) is a vowel, a digit, or any other symbol
*/
using System;

namespace Exercice_09
{
    class Program
    {
        static void Main(string[] args)
        {
            char userInput;
            Console.WriteLine(@"Takes a character as input and check the input
    (lowercase) is a vowel, a digit, or any other symbol");

            Console.Write("Press a key ");
            userInput = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if(Char.IsDigit(userInput))
            {
                Console.WriteLine($"The char {userInput} is a number");
            }
            else if("aeiou".IndexOf(userInput) != -1)
            {
                Console.WriteLine($"The char {userInput} is a lowercase voyel");
            }
            else if(Char.IsLetter(userInput))
            {
                Console.WriteLine($"The char {userInput} is a lowercase consonant");
            }
            else
            {
                Console.WriteLine($"The char {userInput} is a symbol");
            }
        }
    }
}
