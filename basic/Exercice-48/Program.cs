/*
Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more.
    Test Data:
    Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
    Sample Output
    True
*/
using System;

namespace Exercice_48
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            
            Console.WriteLine("Check if the first element and the last element are equal of an array of integers and the length is 1 or more.");
            Console.WriteLine($"Array: [{string.Join(",", nums)}]");

            Console.WriteLine((nums.Length >=1 && nums[0] == nums[^1]) ? true : false);
        }
    }
}
