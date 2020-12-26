/*
Write a C# Sharp program to compute the sum of the two given arrays of integers,
    length 3 and find the array which has the largest sum
*/
using System;
using System.Linq;

namespace Exercice_102
{
    class Program
    {
        public static int[] GetLargerArray(int[] firstArray, int[] secondArray)
        {
            return firstArray.Sum() >= secondArray.Sum() ?
                firstArray :
                secondArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Compute the sum of the two given arrays of integers,
    length 3 and find the array which has the largest sum");

            Console.WriteLine("Larger array: " +
                $"{{{String.Join(",",GetLargerArray(new int[]{10,20,-30}, new int[]{10,20,30}))}}}");
        }
    }
}
