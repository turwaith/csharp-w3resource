/*
Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers.
*/
using System;

namespace Exercice_57
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3,9,12,3,0,3,1};
            int max = 0,
                maxFirstIndex = 0,
                maxSecondIndex = 0;

            Console.WriteLine("Find the pair of adjacent elements that has the highest product of an given array of integers.");
            Console.WriteLine($"Array: [{string.Join(",", nums)}]");

            for(int i = 0; i < nums.Length -1; i++)
            {
                if(nums[i] * nums[i+1] > max)
                {
                    max = nums[i] * nums[i+1];
                    maxFirstIndex = nums[i];
                    maxSecondIndex = nums[i+1];
                }
            }

            Console.WriteLine($"Highest prodcut of adjacent elements: {maxFirstIndex} and {maxSecondIndex}");
        }
    }
}
