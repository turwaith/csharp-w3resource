/*
Write a C# Sharp program to create a new array taking the first two elements from a given array.
If the length of the given array is less than 2 then return the give array
*/
using System;

namespace Exercice_108
{
    class Program
    {
        public static int[] SetNewArray(int[] numbers)
        {
            if(numbers.Length < 2) return numbers;
            else return numbers[0..2];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array taking the first two elements from a given array.
If the length of the given array is less than 2 then return the give array");
        
            Console.WriteLine($"{{{String.Join(",",SetNewArray(new int[]{1,5,7,9,11,13}))}}}");
            Console.WriteLine($"{{{String.Join(",",SetNewArray(new int[]{1}))}}}");
        }
    }
}
