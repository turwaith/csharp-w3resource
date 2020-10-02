/*
 Write a C# program to multiply corresponding elements of two arrays of integers.
Sample Output:
    Array1: [1, 3, -5, 4]
    Array2: [1, 4, -5, -2]
    Multiply corresponding elements of two arrays:
    1 12 25 -8
*/
using System;

namespace Exercice_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {1,3,-5,4};
            int[] array2 = {1,4,-5,-2};
            int[] array3 = new int[4];

            for(int i = 0, size = array1.Length; i < size; i++)
            {
                array3[i] = array1[i] * array2[i];
            }

            Console.WriteLine($"Array1: [{String.Join(",", array1)}]");
            Console.WriteLine($"Array2: [{String.Join(",", array2)}]");
            Console.WriteLine("Multiply corresponding elements of two arrays:");
            Console.WriteLine(String.Join(" ", array3));
        }
    }
}
