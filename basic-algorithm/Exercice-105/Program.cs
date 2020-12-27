/*
Write a C# Sharp program to create a new array swapping the first
    and last elements of a given array of integers and length will be least 1
*/
using System;

namespace Exercice_105
{
    class Program
    {
        public static void GetNewArray(int[] original)
        {
            int[] output = new int[original.Length];
            
            original.CopyTo(output,0);
            output[0] = original[^1];
            output[^1] = original[0];
            
            Console.WriteLine($"Original  array : {{{String.Join(",",original)}}}");
            Console.WriteLine($"Swapped  array  : {{{String.Join(",",output)}}}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array swapping the first
    and last elements of a given array of integers and length will be least 1");

            GetNewArray(new int[]{1,5,7,9,11,13});
            GetNewArray(new int[]{19,33,0,5,69,88});
        }
    }
}
