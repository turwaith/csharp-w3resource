/*
 Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
 */
using System;

namespace Exercice_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumberOne, userNumberTwo, sum;

            Console.Write("Enter the first integer: ");
            userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            userNumberTwo = Convert.ToInt32(Console.ReadLine());

            sum = userNumberOne + userNumberTwo;

            if(userNumberOne == 20 || userNumberTwo == 20 || sum == 20) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
    }
}
