/*
Write a C# Sharp program to compute the sum of the two given integers.
If one of the given integer value is in the range 10..20 inclusive return 18
*/
using System;

namespace Exercice_45
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0,
                numberTwo = 0;
            int sum = 0;

            Console.WriteLine("Compute the sum of the two given integers." +
                              "\nIf one of the given integer value is in the range 10..20 inclusive return 18");
        
            Console.Write("Enter the first integer: ");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            sum = (10 <= numberOne && numberOne <= 20) || (10 <= numberTwo && numberTwo <= 20) ? 18 : numberOne + numberTwo;
        
            Console.WriteLine($"Output: {sum}");
        }
    }
}
