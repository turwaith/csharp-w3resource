/*
Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
Test Data:
    Input the first number to multiply: 2
    Input the second number to multiply: 3
    Input the third number to multiply: 6
Expected Output:
    2 x 3 x 6 = 36
*/
using System;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber;

            Console.Write("Input the first number to multiply: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the first number to multiply: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the first number to multiply: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{firstNumber} x {secondNumber} x {thirdNumber} = {(firstNumber*secondNumber*thirdNumber)}");
        }
    }
}
