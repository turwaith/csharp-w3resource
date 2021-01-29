/*
 Write a C# Sharp program to check a given array of integers and return true 
    if the array contains three increasing adjacent numbers.
 */
using System;

namespace Exercice_126
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers and return true 
    if the array contains three increasing adjacent numbers.");

            Console.WriteLine(IsIncreasingSerie(new int[]{1,2,3,5,3,7}));
            Console.WriteLine(IsIncreasingSerie(new int[]{3,7,5,5,3,7}));
            Console.WriteLine(IsIncreasingSerie(new int[]{3,7,5,5,6,7,5}));
        }

        public static bool IsIncreasingSerie(int[] numbers)
        {
            int count = 0;

            for(int i = 0, size = numbers.Length-1; i < size; i++)
            {
                if(count == 2) return true;
                else if(numbers[i] < numbers[i+1]) count++;
                else
                {
                    count = 0;
                    i++;
                }
            }
            return false;
        }
    }
}
