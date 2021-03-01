/*
Write a C# Sharp program to check if the value of each element is equal or
    greater than the value of previous element of a given array of integers
*/
using System;

namespace Exercice_133
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check if the value of each element is equal or
    greater than the value of previous element of a given array of integers");

            Check(new int[] { 5, 5, 1, 5, 5 });
            Check(new int[] { 1, 2, 3, 4 });
            Check(new int[] { 3, 3, 5, 5, 5, 5});
            Check(new int[] { 1, 5, 5, 7, 8, 10});
        }

        static void Check(int[] numbers)
        {
            bool isPreviousLower = false;

            for(int i = 1, size = numbers.Length; i < size; i ++)            
            {
                if(numbers[i] >= numbers[i-1])
                {
                    isPreviousLower = true;
                }
                else
                {
                    isPreviousLower = false;
                    break;
                }
            }
            
            Console.WriteLine($"[{String.Join(",",numbers)}] : {isPreviousLower}");
        }
    }
}
