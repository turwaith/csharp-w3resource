/*
Write a C# program to rotate an array (length 3) of integers in left direction.
    Test Data:
    Array1: [1, 2, 8]
    After rotating array becomes: [2, 8, 1]
*/
using System;

namespace Exercice_50
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,2,8,4,5,8,5,9};
            
            Console.WriteLine($"Rotate an array (length {nums.Length}) of integers in left direction.");
            Console.WriteLine($"Original array: [{string.Join(",", nums)}]");
            
            int temp = nums[0];
            for(int i = 0; i < nums.Length - 1; i++)
            {                
                nums[i] = nums[i+1];                
            }
            nums[^1] = temp;

            Console.WriteLine($" Rotated array: [{string.Join(",", nums)}]");
        }
    }
}
