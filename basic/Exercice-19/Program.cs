/*
Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum
*/
using System;

namespace Exercice_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne, numberTwo, sum;

            Console.Write("Enter the first number: ");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            if(numberOne == numberTwo) sum = (numberOne + numberTwo) * 3;
            else sum = numberOne + numberTwo;

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
