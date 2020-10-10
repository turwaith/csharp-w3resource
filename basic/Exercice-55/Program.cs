/*
Write a C# program to find the pair of adjacent elements that has the 
    largest product of an given array which is equal to a given value.
    Data:
    [2, 4, 2, 6, 9, 3]   == 27  => False
    [0, -1,-1, -2]       == 2   => True
    [6, 1, 12, 3, 1, 4]  == 36  => True
    [1, 4, 3, 0]         == 16  => False
*/
using System;

namespace Exercice_55
{
    class Program
    {
        static bool ProductIsEqualTo(int[] nums, int num)
        {
            int sum = 0;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i] * nums[i+1] > sum) sum = nums[i] * nums[i+1];                
            }            
            return sum == num;
        }
        static void Main(string[] args)
        {
            int[] nums1 = {2, 4, 2, 6, 9, 3},
                  nums2 = {0, -1,-1, -2},
                  nums3 = {6, 1, 12, 3, 1, 4},
                  nums4 = {1, 4, 3, 0},
                  nums5 = {27, 2, 36, 16};

            Console.WriteLine("Find the pair of adjacent elements that has the\n"+
            "largest product of an given array which is equal to a given value.");

            Console.WriteLine($"Array1: {"[" + string.Join(",",nums1) + "]",-14} {nums5[0], 5} {ProductIsEqualTo(nums1, nums5[0])}");
            Console.WriteLine($"Array2: {"[" + string.Join(",",nums2) + "]",-14} {nums5[1], 5} {ProductIsEqualTo(nums2, nums5[1])}");
            Console.WriteLine($"Array3: {"[" + string.Join(",",nums3) + "]",-14} {nums5[2], 5} {ProductIsEqualTo(nums3, nums5[2])}");
            Console.WriteLine($"Array4: {"[" + string.Join(",",nums4) + "]",-14} {nums5[3], 5} {ProductIsEqualTo(nums4, nums5[3])}");
        }
    }
}
