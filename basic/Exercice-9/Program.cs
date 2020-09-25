/*
Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
    Enter the First number: 10
    Enter the Second number: 15
    Enter the third number: 20
    Enter the four number: 30
Expected Output:
    The average of 10 , 15 , 20 , 30 is: 18
*/
using System;

namespace Exercice_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber, average;

            Console.Write("Enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            fourthNumber = Convert.ToInt32(Console.ReadLine());

            average = (firstNumber + secondNumber + thirdNumber +fourthNumber) / 4;

            Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} is : {average}");
        }
    }
}
