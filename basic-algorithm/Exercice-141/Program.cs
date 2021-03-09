/*
Write a C# Sharp program to create a new list from a given list of integers where each element is multiplied by 3
*/
using System;

namespace Exercice_141
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new list from a given list of 
integers where each element is multiplied by 3");

            Console.WriteLine($"[{String.Join(",",Multiply(new int[]{ 1, 2, 3 , 4 },3))}]");
        }

        static int[] Multiply(int[] numbers, int multiplier)
        {
            Console.Write($"[{String.Join(",",numbers)}] -> ");

            for(int i = 0, max = numbers.Length; i < max; i++)
                numbers[i] *= multiplier;
            
            return numbers;
        }
    }
}
