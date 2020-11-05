/*
Write a C# Sharp program to check the largest number among three given integers.
*/
using System;

namespace Exercice_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userNumbers = new int[3];
            string userInput = String.Empty;
            int max = 0;

            Console.WriteLine("Check the largest number among three given integers");

            Console.Write("Enter your three integers (coma separeted): ");
            userInput = Console.ReadLine();

            userNumbers[0] = Convert.ToInt32(userInput.Split(",")[0]);
            userNumbers[1] = Convert.ToInt32(userInput.Split(",")[1]);
            userNumbers[2] = Convert.ToInt32(userInput.Split(",")[2]);

            // whitout built in method
            foreach(int item in userNumbers)
                if(item > max) max = item;           

            Console.WriteLine($"The largest number is                     : {max}");
        }
    }
}
