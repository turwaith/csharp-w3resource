/*
Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5
*/
using System;

namespace Exercice_41
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int numberOne = 0,
                numberTwo = 0;
            bool numbersMatch = false;
            
            Console.WriteLine("Accept two integers and return true if either one is 5 or their sum or difference is 5");

            Console.Write("Enter two integers (coma separeted): ");
            userInput = Console.ReadLine();

            numberOne = Convert.ToInt32(userInput.Split(",")[0]);
            numberTwo = Convert.ToInt32(userInput.Split(",")[1]);

            numbersMatch = numberOne == 5 ||
                           numberTwo == 5 ||
                           Math.Abs((numberOne - numberTwo)) == 5 ||
                           (numberOne + numberTwo) == 5 ?
                           true :
                           false;

            Console.WriteLine($"Output: {numbersMatch}");
        }
    }
}
