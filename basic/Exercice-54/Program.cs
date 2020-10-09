/*
Write a C# program to get the century from a year. 
*/
using System;

namespace Exercice_54
{
    class Program
    {
        static int GetCentury(int year)
        {
            return (year / 100) + (year % 100 == 0 ? 0 : 1);
        }
        static void Main(string[] args)
        {
            int userInput = 0;
            Console.Write("Enter a year to get the century: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Century: {GetCentury(userInput)}");
        }
    }
}
