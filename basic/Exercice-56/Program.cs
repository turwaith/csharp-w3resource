/*
Write a C# program to check if a given string is a palindrome or not.
    Sample Example:
    For 'aaa' the output should be true
    For 'abcd' the output should be false
*/
using System;

namespace Exercice_56
{
    class Program
    {
        static void Main(string[] args)
        {
            string original;
            char[] reversed; 

            Console.WriteLine("Check if a given string is a palindrome or not.");

            Console.Write("Input a string: ");
            original = string.Join("",Console.ReadLine().ToLower().Trim().Split(' '));

            reversed = original.ToCharArray();            
            Array.Reverse(reversed);

            Console.WriteLine($"It's {(original.Equals(string.Join("",reversed)) ? "" : "not ")}a palindrome.");
        }
    }
}
