/*
Write a C# program to check if an given integer is within 20 of 100 or 200.
Sample Output:
    Input an integer:
    25
    False
*/
using System;

namespace Exercice_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            bool isWithin;

            Console.Write("Input an integer: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            isWithin = (Math.Abs(userInput - 100) <= 20) || (Math.Abs(userInput - 200) <= 20) ? true : false;

            Console.WriteLine(isWithin);
        }
    }
}
