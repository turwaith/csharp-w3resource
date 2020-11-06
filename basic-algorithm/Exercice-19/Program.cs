/*
Write a C# Sharp program to check which number nearest to the value 100 among two given integers.
Return 0 if the two numbers are equal
*/
using System;

namespace Exercice_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int numberOne = 0,
                numberTwo = 0;

            Console.WriteLine("Check which number nearest to the value 100 among two given integers." +
                              "\nReturn 0 if the two numbers are equal");

            Console.Write("Enter your two integers (coma separeted): ");
            userInput = Console.ReadLine();
            numberOne = Convert.ToInt32(userInput.Split(",")[0]);
            numberTwo = Convert.ToInt32(userInput.Split(",")[1]);

            if(numberOne == numberTwo) Console.WriteLine("0");
            else if(numberOne > numberTwo) Console.WriteLine(numberOne);
            else Console.WriteLine(numberTwo);
        }
    }
}
