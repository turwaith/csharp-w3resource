/*
Write a C# program to count a specified number in a given array of integers.
    Test Data:
    Input an integer: 5
    Sample Output
    Number of 5 present in the said array: 2
*/
using System;

namespace Exercice_45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            int count = 0,
                userInput = 0;

            Console.WriteLine("Count a specified number in a given array of integers.");
            Console.WriteLine($"Array: [{string.Join(",", nums)}]");

            Console.Write("Input an integer: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            foreach(int item in nums)
            {
                if(item == userInput) count++;
            }

            Console.WriteLine($"Number of {userInput} present in the said array: {count}");
        }
    }
}
