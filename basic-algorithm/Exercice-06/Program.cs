/*
Write a C# Sharp program to remove the character in a given position of a given string.
The given position will be in the range 0.. string length -1 inclusive.
*/
using System;

namespace Exercice_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputString = String.Empty;
            int userInputPosition = 0;

            Console.WriteLine("Remove the character in a given position of a given string." +
                              "The given position will be in the range 0.. string length -1 inclusive.");

            Console.Write("Enter your string : ");
            userInputString = Console.ReadLine();
            Console.Write("Enter the position: ");
            userInputPosition = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"New string:         {userInputString.Remove(userInputPosition,1)}");
        }
    }
}
