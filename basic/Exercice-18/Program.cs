/*
 Write a C# program to check two given integers and return true if one is negative and one is positive.
Sample Output:
    Input first integer:
    -5
    Input second integer:
    25
    Check if one is negative and one is positive:
    True
*/
using System;

namespace Exercice_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            bool isNegAndPos;

            Console.Write("Input first integer: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            
            if((firstNumber < 0 && secondNumber > 0) || (firstNumber > 0 && secondNumber < 0)) isNegAndPos = true;
            else isNegAndPos = false;

            Console.Write($"Check if one is negative and one is positive: {isNegAndPos}");

        }
    }
}
