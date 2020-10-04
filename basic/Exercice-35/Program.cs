/*
Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
Sample Output:
    Input a first number(<100): 75
    Input a second number(>100): 250
    True
*/
using System;

namespace Exercice_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0, numberTwo = 0;

            Console.WriteLine("Check two given numbers where one is less than 100 and other is greater than 200.");
            Console.Write("Input a first number(<100): ");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number(<200): ");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numberOne < 100 && numberTwo > 200);
        }
    }
}
