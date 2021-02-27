/*
Write a C# Sharp program to create a new array after replacing all the values 5 
    with 0 shifting all zeros to right direction
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercice_131
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array after replacing all the
            values 5 with 0 shifting all zeros to right direction");

            ShiftZeroToRight(new int[]{ 1, 2, 5, 3, 5, 7, 5, 9, 11 });
            Console.WriteLine("-----");
            ShiftZeroToRight(new int[]{ 1, 5, 5, 3, 5, 7, 5, 9, 5 });
        }

        static void ShiftZeroToRight(int[] numbers)
        {
            int[] output = new int[numbers.Length];

            for(int i = 0, max = numbers.Length, count = 0; i < max; i++)
            {
                if(numbers[i] != 5)
                {
                    output[count++] = numbers[i];
                }

            }

            Console.WriteLine($"Old: [{String.Join(",",numbers)}]");
            Console.WriteLine($"New: [{String.Join(",",output)}]");
        }
    }
}
