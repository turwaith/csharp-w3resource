/*
Write a C# Sharp program to find the larger value from two positive integer values 
    that is in the range 20..30 inclusive, or return 0 if neither is in that range.
*/
using System;

namespace Exercice_21
{
    class Program
    {
        private static int GetLargerInRange(int numberOne, int numberTwo, int min = 20, int max =  30)
        {
            if((min <= numberOne && numberOne <= max) && (min <= numberTwo && numberTwo <= max))
            {
                return numberOne > numberTwo ? numberOne : numberTwo;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int numberOne = 0,
                numberTwo = 0;

            Console.WriteLine("Find the larger value from two positive integer values" +
                              "that is in the range 20..30 inclusive, \n   or return 0 if neither is in that range");

            Console.Write("Enter two integers (coma separeted): ");
            userInput = Console.ReadLine();
            numberOne = Convert.ToInt32(userInput.Split(",")[0]);
            numberTwo = Convert.ToInt32(userInput.Split(",")[1]);

            Console.WriteLine(GetLargerInRange(numberOne, numberTwo));
        }
    }
}
