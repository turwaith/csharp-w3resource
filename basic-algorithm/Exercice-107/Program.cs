/*
Write a C# Sharp program to find the largest value from first, last, and middle
    elements of a given array of integers of odd length (atleast 1)
*/
using System;

namespace Exercice_107
{
    class Program
    {
        public static int GetLargerNumber(int[] numbers)
        {
            Console.Write($"{{{String.Join(",",numbers)}}}\n");

            if(numbers.Length % 2 == 0)
            {
                Console.Write("Can't get the middle of a even array ");
                return 0;
            }
            else
            {
                int middle = numbers.Length / 2;
                return numbers[middle] > numbers[^1] ? numbers[middle] : numbers[^1];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Find the largest value from first, last, and middle
    elements of a given array of integers of odd length (atleast 1)");

            Console.WriteLine(GetLargerNumber(new int[]{1}));
            Console.WriteLine(GetLargerNumber(new int[]{1,2,9}));
            Console.WriteLine(GetLargerNumber(new int[]{1,2,9,3,3}));
            Console.WriteLine(GetLargerNumber(new int[]{1,2,3,4,5,6,7}));
            Console.WriteLine(GetLargerNumber(new int[]{1,2,2,3,7,8,9,10,6,5,4}));
            Console.WriteLine(GetLargerNumber(new int[]{1,2,2,3}));
        }
    }
}
