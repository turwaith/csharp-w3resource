/*
Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.
    Test Data:
    Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
    Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
    Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal.
    Sample Output
    True
*/
using System;

namespace Exercice_49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1},
                  nums2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};

            Console.WriteLine("Check if the first element or the last element of the two arrays ( length 1 or more) are equal.");
            Console.WriteLine($"Array1: [{string.Join(",",nums1)}]");
            Console.WriteLine($"Array2: [{string.Join(",",nums2)}]");

            Console.WriteLine((nums1[0] == nums2[0] || nums1[^1] == nums2[^1]) ? true : false);
        }
    }
}
