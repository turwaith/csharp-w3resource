/*
Write a C# Sharp program to check if the number of 3's is greater than the number of 5's
*/
using System;
using System.Linq;

namespace Exercice_116
{
    class Program
    {
        public static bool IsGreater(int[] numbers)
        {
            return numbers.Count(item => item == 3) > numbers.Count(item => item == 5);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check if the number of 3's is greater than the number of 5's");

            Console.WriteLine(IsGreater(new int[] {1,5,6,9,3,3}));
            Console.WriteLine(IsGreater(new int[] {1,5,5,5,10,17}));
            Console.WriteLine(IsGreater(new int[] {1,3,3,5,5,5}));
        }
    }
}
