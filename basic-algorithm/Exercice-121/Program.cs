/*
Write a C# Sharp program to check a given array of integers and return true if
    there is a 3 with a 5 somewhere later in the given array.
*/
using System;

namespace Exercice_121
{
    class Program
    {
        public static bool IsNext(int[] numbers)
        {
            int threeIndex = Array.IndexOf(numbers, 3);
            return (threeIndex >= 0) && (Array.IndexOf(numbers[threeIndex..],5) >= 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers and return true if
    there is a 3 with a 5 somewhere later in the given array.");
        
            Console.WriteLine(IsNext(new int[]{3,5,1,3,7 }));
            Console.WriteLine(IsNext(new int[]{1,2,3,4}));
            Console.WriteLine(IsNext(new int[]{3,3,5,5,5,5}));
            Console.WriteLine(IsNext(new int[]{2,5,5,7,8,10}));
            Console.WriteLine(IsNext(new int[]{2,3,0,7,8,5}));
        }
    }
}
