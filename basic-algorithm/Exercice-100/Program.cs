/*
Write a C# Sharp program to check a given array of integers and return
    true if the array contains 10 or 20 twice.
The length of the array will be 0, 1, or 2
*/
using System;
using System.Linq;

namespace Exercice_100
{
    class Program
    {
        public static bool IsTwiceInside(int[] numbers)
        {
            return (numbers.Count(p => p == 10) > 1) || (numbers.Count(p => p == 20) > 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers and return
    true if the array contains 10 or 20 twice.
The length of the array will be 0, 1, or 2");
        
            Console.WriteLine(IsTwiceInside(new int[]{12,20}));
            Console.WriteLine(IsTwiceInside(new int[]{20,20}));
            Console.WriteLine(IsTwiceInside(new int[]{10,10}));
            Console.WriteLine(IsTwiceInside(new int[]{10}));
            Console.WriteLine(IsTwiceInside(new int[]{10,20}));
            Console.WriteLine(IsTwiceInside(new int[]{10,20,10,52,12,0}));
        }
    }
}
