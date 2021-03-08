/*
Write a C# Sharp program to create a new array of given length
    using the odd numbers from a given array of positive integers
 */
using System;

namespace Exercice_140
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array of given length
    using the odd numbers from a given array of positive integers");

            Console.WriteLine(GetNewArray(new int[]{1,2,3,5,7,9,10},3));
            Console.WriteLine(GetNewArray(new int[]{1,2,3,5,7,9,10},5));
        }

        static string GetNewArray(int[] numbers, int size)
        {
            int[] output = new int[size];

            Console.Write($"[{String.Join(",",numbers)}] -> ");

            for(int i = 0, index = 0, max = numbers.Length;
                i < max;
                i++)
            {
                if(index == size) break;
                if(numbers[i] % 2 != 0)
                {
                    output[index++] = numbers[i];
                }
            }

            return $"[{String.Join(",",output)}]";
        }
    }
}
