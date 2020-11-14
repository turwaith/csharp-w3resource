/*
Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere
*/
using System;
using System.Linq;

namespace Exercice_34
{
    class Program
    {
        private static bool SerieIsInside(string[] numbersArray)
        {
            for(int i = 0; i < numbersArray.Length; i++)            
                if(i <= (numbersArray.Length - 3) && numbersArray[i] == "1" && numbersArray[i+1] =="2" && numbersArray[i+2] == "3")
                    return true;
                return false;
        }
        static void Main(string[] args)
        {
            string[] numbersArray;

            Console.WriteLine("Check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere");

            Console.Write("Enter your array (coma separeted): ");
            numbersArray = Console.ReadLine().Split(",");

            Console.WriteLine(SerieIsInside(numbersArray));
        }
    }
}
