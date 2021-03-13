/*
Write a C# Sharp program that takes three letters as input and display them in reverse order
*/
using System;

namespace Exercice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Takes three letters as input and display them in reverse order");

            char[] userInputs = GetUserLetter();
            Console.WriteLine($"You entered the following letters (reversed) : [{String.Join(",",userInputs)}]");
        }

        static char[] GetUserLetter()
        {
            char[] userInputs = new char[3];

            for(int i = 0, max = userInputs.Length; i < max; i++)
            {
                Console.Write("Enter a letter: ");
                userInputs[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            Array.Reverse(userInputs);
            return userInputs;
        }
    }
}
