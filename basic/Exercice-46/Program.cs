/*
Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.
    Test Data:
    Input an integer: 25
    Sample Output
    False
*/
using System;

namespace Exercice_46
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            int userInput = 0;

            Console.WriteLine("Check if a number appears as either the first or last element of an array of integers and the length is 1 or more.");
            Console.Write("Input an integer: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(nums[0] == userInput || nums[^1] == userInput);
        }
    }
}
