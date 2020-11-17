/*
Write a C# Sharp program to check if a triple is presents in an array of integers or not.
If a value appears three times in a row in an array it is called a triple
*/
using System;

namespace Exercice_39
{
    class Program
    {
        public static bool TripleIsInside(string[] userNumbers)
        {            
            for(int i = 0; i <= (userNumbers.Length - 3); i+=3)
                if(userNumbers[i] == userNumbers[i+1] && userNumbers[i] == userNumbers[i+2]) return true;
            
            return false;
        }
        static void Main(string[] args)
        {
            string[] userNumbers;

            Console.WriteLine("Check if a triple is presents in an array of integers or not." +
                              "\nIf a value appears three times in a row in an array it is called a triple");
        
            Console.Write("Enter your numbers (coma separeted): ");
            userNumbers = Console.ReadLine().Split(",");

            Console.WriteLine($"Triple inside: {TripleIsInside(userNumbers)}");
        }
    }
}
