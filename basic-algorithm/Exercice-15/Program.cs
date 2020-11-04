/*
Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive.
Return true if 1 or more of them are in the said range otherwise false.
 */
using System;

namespace Exercice_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int numberOne = 0,
                numberTwo = 0,
                numberThree = 0;

            Console.WriteLine("Check whether three given integer values are in the range 20..50 inclusive." +
                              "\nReturn true if 1 or more of them are in the said range otherwise false");
                              
            Console.Write("Enter your three integers (coma separeted): ");
            userInput = Console.ReadLine();

            numberOne = Convert.ToInt32(userInput.Split(",")[0]);
            numberTwo = Convert.ToInt32(userInput.Split(",")[1]);
            numberThree = Convert.ToInt32(userInput.Split(",")[2]);

            Console.WriteLine((20 <= numberOne && numberOne <= 50) ||
                              (20 <= numberTwo && numberTwo <= 50) ||
                              (20 <= numberThree && numberThree <= 50) ?
                              "true" : "false");
        }
    }
}
