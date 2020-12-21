/*
Write a C# Sharp program to rotate the elements of a given array of integers
    (length 4 ) in left direction and return the new array
*/
using System;

namespace Exercice_92
{
    class Program
    {
        public static int[] RotatedArray(int[] numbers)
        {
            int[] output = new int[numbers.Length];

            output[^1] =  numbers[0];

            for(int i = 0, size = numbers.Length-1; i < size; i++)            
                  output[i] =  numbers[i+1];
            
            return output;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Rotate the elements of a given array of integers
    (length 4 ) in left direction and return the new array");

            Console.WriteLine($"{{{String.Join(",",RotatedArray(new int[]{10,20,-30,-40}))}}}");
        }
    }
}
