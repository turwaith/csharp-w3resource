/*
Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
Sample Output:
    Input a first number: -5
    Input a second number: 8
    True
*/
using System;

namespace Exercice_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0, numberTwo = 0;
            bool isInRange = false;

            Console.WriteLine("Check if an integer (from the two given integers) is in the range -10 to 10.");

            Console.Write("Input a first number: ");
            numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a second number: ");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            isInRange = (-10 < numberOne && numberOne < 10) && (-10 < numberTwo && numberTwo < 10);

            Console.WriteLine(isInRange);
        }
    }
}
