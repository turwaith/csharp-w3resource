/*
Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7
*/
using System;

namespace Exercice_10
{
    class Program
    {
        static string MultipleOf(int userInput, int a = 3,int b = 7)
        {
            if(userInput % a == 0 && userInput % b == 0) return $"of {a} and {b}";
            else if(userInput % a == 0) return $"of {a}";
            else if(userInput % b == 0) return $"of {b}";
            else return $"neither of {a} and of {b}";
        }
        static void Main(string[] args)
        {
            int userInput = 0;

            Console.WriteLine("Check if a given positive number is a multiple of 3 or a multiple of 7");

            Console.Write("Enter your number: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The number is a muliple {MultipleOf(userInput)}");
        }
    }
}
