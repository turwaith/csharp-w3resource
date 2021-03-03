/*
Write a C# Sharp program to find the larger average value between the first and the
second half of a given array of integers and minimum length is atleast 2.
Assume that the second half begins at index (array length)/2
*/
using System;
using System.Linq;

namespace Exercice_135
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Find the larger average value between the first and the
second half of a given array of integers and minimum length is atleast 2.
Assume that the second half begins at index (array length)/2");

            Console.WriteLine(GetLargerAverage(new int[]{ 1, 2, 3, 4, 6, 8 }));
            Console.WriteLine(GetLargerAverage(new int[]{ 15, 2, 3, 4, 15, 11 }));
        }

        static double GetLargerAverage(int[] numbers)
        {
            int half = (numbers.Length / 2);
            int[] firstHalf = numbers[0..half],
                  secondHalf = numbers[half..];

            Console.Write($"[{String.Join(",",numbers)}] -> ");

            return firstHalf.Average() > secondHalf.Average() ? firstHalf.Average() : secondHalf.Average();
        }
    }
}
