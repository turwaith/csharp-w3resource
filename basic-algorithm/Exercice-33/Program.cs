/*
Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element
*/
using System;
using System.Linq;

namespace Exercice_33
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersArray;
            string numberToFind = String.Empty;

            Console.WriteLine("Check if one of the first 4 elements in an array of integers is equal to a given element");

            Console.Write("Enter your array (coma separeted): ");
            numbersArray = Console.ReadLine().Split(",");

            Console.Write("Enter the number to find: ");
            numberToFind = Console.ReadLine();

            Console.WriteLine(numbersArray[0..4].Contains(numberToFind));
        }
    }
}
