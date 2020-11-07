/*
Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive,
    or they are both in the range 50..60 inclusive
*/
using System;

namespace Exercice_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int numberOne = 0,
                numberTwo = 0;

            Console.WriteLine("Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive," +
                              "or they are both in the range 50..60 inclusive");
            
            Console.Write("Enter two integers (coma separeted): ");
            userInput = Console.ReadLine();
            numberOne = Convert.ToInt32(userInput.Split(",")[0]);
            numberTwo = Convert.ToInt32(userInput.Split(",")[1]);

            Console.WriteLine((40 <= numberOne && numberOne <= 60) && (40 <= numberTwo && numberTwo <= 60) ? "true" : "false");
        }
    }
}
