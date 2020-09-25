/*
Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers 
    which will be entered by the user.
Test Data:
    Input the first number: 25
    Input the second number: 4
Expected Output:
    25 + 4 = 29
    25 - 4 = 21
    25 x 4 = 100
    25 / 4 = 6
    25 mod 4 = 1
*/
using System;

namespace Exercice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;

            Console.Write("Input the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the first number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{firstNumber} + {secondNumber} {"=",3} {(firstNumber + secondNumber)}");
            Console.WriteLine($"{firstNumber} - {secondNumber} {"=",3} {(firstNumber - secondNumber)}");
            Console.WriteLine($"{firstNumber} x {secondNumber} {"=",3} {(firstNumber * secondNumber)}");
            Console.WriteLine($"{firstNumber} mod {secondNumber} {"=",1} {(firstNumber % secondNumber)}");
        }
    }
}
