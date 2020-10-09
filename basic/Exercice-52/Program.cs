/*
Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
    Test Data:
    Array1: [1, 2, 5]
    Array2: [0, 3, 8]
    Array3: [-1, 0, 2]
    New array: [2, 3, 0]
*/
using System;

namespace Exercice_52
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {1, 2, 5},
                  nums2 = {0, 3, 8},
                  nums3 = {-1, 0, 2},
                  nums4 = new int[3];

            Console.WriteLine("Create a new array of length containing the middle elements of three arrays (each length 3) of integers.");
        
            nums4[0] = nums1[1];
            nums4[1] = nums2[1];
            nums4[2] = nums3[1];

            Console.WriteLine($"Array4: [{string.Join(",", nums1)}]");
            Console.WriteLine($"Array4: [{string.Join(",", nums2)}]");
            Console.WriteLine($"Array4: [{string.Join(",", nums3)}]");
            Console.WriteLine($"Array4: [{string.Join(",", nums4)}]");
        }
    }
}
