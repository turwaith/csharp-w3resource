/*
Write a C# Sharp program to swap two numbers.
Test Data:
    Input the First Number : 5
    Input the Second Number : 6
Expected Output:
After Swapping :
    First Number : 6
    Second Number : 5
*/
using System;

namespace Exercice_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5,
                secondNumber = 6,
                tempNumber = 0;

            Console.WriteLine("Variables before swapping:");
            Console.WriteLine($"\tFirst number = {firstNumber}");
            Console.WriteLine($"\tSecond number = {secondNumber}");

            tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;

            Console.WriteLine("Variables after swapping:");
            Console.WriteLine($"\tFirst number = {firstNumber}");
            Console.WriteLine($"\tSecond number = {secondNumber}");
        }
    }
}
