/*
Write a C# Sharp program to check a specified number is present in a given array of integers
*/
using System;
using System.Linq;

namespace Exercice_32
{
    class Program
    {
        static void Main(string[] args)
        {            
            string numberToFind = String.Empty;
            string[] numbersArray;

            Console.WriteLine("Check a specified number is present in a given array of integers");
        
            Console.Write("Enter your array (coma separeted): ");
            numbersArray = Console.ReadLine().Split(",");            

            Console.Write("Enter the number to find: ");
            numberToFind =  Console.ReadLine();

            Console.WriteLine(numbersArray.Contains(numberToFind));
        }
    }
}
