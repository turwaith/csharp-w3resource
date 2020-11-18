/*
Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30
*/
using System;

namespace Exercice_40
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int userNumberOne = 0,
                userNumberTwo = 0,
                total = 0,
                output = 0;

            Console.WriteLine("Compute the sum of the two given integers." +
                              "If the sum is in the range 10..20 inclusive return 30");
        
            Console.Write("Enter two integers (coma separeted): ");
            userInput = Console.ReadLine();
            userNumberOne = Convert.ToInt32(userInput.Split(",")[0]);
            userNumberTwo = Convert.ToInt32(userInput.Split(",")[1]);
            total = userNumberOne + userNumberTwo;

            output = total >= 10 && total <= 20 ? 30 : total;

            Console.WriteLine($"Output: {output}");
        }
    }
}
