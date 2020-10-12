/*
Write a C# program to check whether it is possible to create a strictly 
    increasing sequence from a given sequence of integers as an array.
*/
using System;

namespace Exercice_59
{
    class Program
    {
        static bool IsIncreasingArray(int[] sequence)
        {
            int[] sequenceSorted = (int[])sequence.Clone();
            Array.Sort(sequenceSorted);
            for(int i = 0; i < sequence.Length - 1; i++)
            {
                if(sequence[i] != sequenceSorted[i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] nums1 = {1,3,5,6,9},
                  nums2 = {0,10},
                  nums3 = {1,3,1,3};

            Console.WriteLine("Check whether it is possible to create a strictly " +
                              "increasing sequence from a given sequence of integers as an array.");

            Console.WriteLine($"Array1: [{string.Join(",", nums1)}] can be a strictly increasing array ? {IsIncreasingArray(nums1)}");
            Console.WriteLine($"Array1: [{string.Join(",", nums2)}] can be a strictly increasing array ? {IsIncreasingArray(nums2)}");
            Console.WriteLine($"Array1: [{string.Join(",", nums3)}] can be a strictly increasing array ? {IsIncreasingArray(nums3)}");
        }
    }
}
