/*
Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z
*/
using System;

namespace Exercice_48
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput;
            bool isGreater = false;

            Console.WriteLine("Check if y is greater than x, and z is greater than y from three given integers x,y,z");
        
            Console.Write("Enter 3 integers (coma separeted): ");
            userInput = Console.ReadLine().Split(",");
            isGreater = Convert.ToInt32(userInput[2]) > Convert.ToInt32(userInput[1]) && 
                        Convert.ToInt32(userInput[1]) > Convert.ToInt32(userInput[0]);
            
            Console.WriteLine($"Output: {isGreater}");
        }
    }
}
