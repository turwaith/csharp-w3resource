/*
Write a C# program to check if an array contains an odd number.
    Test Data:
    Original array: [2, 4, 7, 8, 6]
    Check if an array contains an odd number? True
*/
using System;

namespace Exercice_53
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {2, 4, 7, 8, 6};
            int[] nums2 = {8, 2, 6, 4, 4};

            Console.WriteLine($"Original array: [{string.Join(",", nums1)}]");
            Console.WriteLine($"Check if an array contains an odd number? {isOdd(nums1)}");
            
            Console.WriteLine($"Original array: [{string.Join(",", nums2)}]");
            Console.WriteLine($"Check if an array contains an odd number? {isOdd(nums2)}");
        }

        static bool isOdd(int[] numsArray)
        {
            foreach(int item in numsArray)
            {
                if(item % 2 != 0) return true;
            }
            return false;
        }
    }
}
