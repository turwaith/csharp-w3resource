/*
Write a C# Sharp program to compare two given strings
    and return the number of the positions where they contain the same length 2 substring
*/
using System;
using System.Linq;

namespace Exercice_35
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFirstInput = String.Empty,
                   userSecondInput = String.Empty;
            int count = 0;

            Console.WriteLine("Compare two given strings and return the number of the positions\n "+
                              "where they contain the same length 2 substring");

            Console.Write("Enter the first string: ");
            userFirstInput = Console.ReadLine();            

            Console.Write("Enter the second string: ");
            userSecondInput = Console.ReadLine();
            
            for(int i = 0; i < userFirstInput.Length-1; i++)
            {                
                if(userSecondInput.Contains(userFirstInput[i..(i+2)])) count++;
            }            

            Console.WriteLine($"Output: {count}");
        }
    }
}
