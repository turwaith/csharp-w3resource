/*
Write a C# Sharp program to create a new array length 3 from a given array
    (length atleast 3) using the elements from the middle of the array
*/
using System;

namespace Exercice_106
{
    class Program
    {
        public static int[] GetNewArray(int[] numbers)
        {
            if(numbers.Length < 3) return numbers;  // 1 2 3 4 5    1 2 5 4
            else
            {
                int middle = (numbers.Length / 2) -1;         
                return numbers[middle..(middle+3)];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array length 3 from a given array
    (length atleast 3) using the elements from the middle of the array");

            Console.WriteLine($"{{{String.Join(",",GetNewArray(new int[]{1,5,7,9,11,13}))}}}");
            Console.WriteLine($"{{{String.Join(",",GetNewArray(new int[]{1,5,7,9}))}}}");
            Console.WriteLine($"{{{String.Join(",",GetNewArray(new int[]{1,5,7}))}}}");
        }
    }
}
