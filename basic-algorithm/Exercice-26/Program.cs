/*
 Write a C# Sharp program to create a new string which is n (non-negative integer)
    copies of the the first 3 characters of a given string.
If the length of the given string is less than 3 then return n copies of the string
 */
using System;

namespace Exercice_26
{
    class Program
    {
        private static string GetNewString(string userString, int number)
        {
            string output = String.Empty;

            if(userString.Length < 3) for(int i = 0; i < number; i++) output += userString;
            else
            {
                for(int i = 0; i < number; i++) output += userString[0..3];
            }

            return output;
        }
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   userString = String.Empty,
                   userOutput = String.Empty;
            int userNumber = 0;
            
            Console.WriteLine("Create a new string which is n (non-negative integer)" +
                              "copies of the the first 3 characters of a given string.\n" +
                              "If the length of the given string is less than 3 then return n copies of the string");

            Console.Write("Enter your string and the number (positive) of repetition (coma separeted): ");
            userInput = Console.ReadLine();
            userString = userInput.Split(",")[0];
            userNumber = Convert.ToInt32(userInput.Split(",")[1]);

            Console.WriteLine(GetNewString(userString, userNumber));
        }
    }
}
