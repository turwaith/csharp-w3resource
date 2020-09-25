/*
Write a C# Sharp program that takes a number as input and print its multiplication table.
Test Data:
    Enter the number: 5
Expected Output:
    5 * 0 = 0
    5 * 1 = 5
    5 * 2 = 10
    5 * 3 = 15
    ....
    5 * 10 = 50
*/
using System;

namespace Exercice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;

            Console.Write("Enter the number: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            for(int i= 0; i < 11; i++) Console.WriteLine($"{userInput} * {i,2} = {(userInput * i)}");
        }
    }
}
