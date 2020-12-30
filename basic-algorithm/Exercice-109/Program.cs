/*
Write a C# Sharp program to count even number of elements in a given array of integers
*/
using System;
using System.Linq;

namespace Exercice_109
{
    class Program
    {
        public static int GetEvenInteger(int[] numbers)
        {
            Console.Write($"{{{String.Join(",",numbers)}}} : ");
            return numbers.Count(item => item % 2 == 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Count even number of elements in a given array of integers");
        
            Console.WriteLine(GetEvenInteger(new int[]{1,5,7,9,10,12}));
            Console.WriteLine(GetEvenInteger(new int[]{50,5,88,9,10,12}));
        }
    }
}
