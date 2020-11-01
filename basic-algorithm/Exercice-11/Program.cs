/*
 Write a C# Sharp program to create a new string taking the first 3 characters of a
    given string and return the string with the 3 characters added at both the front and back.
If the given string length is less than 3, use whatever characters are there. 
 */

using System;

namespace Exercice_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput =  String.Empty;

            Console.WriteLine("create a new string taking the first 3 characters of a" +
                              "given string and return the string with the 3 characters added at both the front and back." +
                              "If the given string length is less than 3, use whatever characters are there.");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            if(userInput.Length < 3) Console.WriteLine(userInput + userInput + userInput);
            else Console.WriteLine(userInput[0..3] + userInput + userInput[0..3]);
        }
    }
}
