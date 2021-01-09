/*
Write a C# Sharp program to check a given array of integers and return
    true if the specified number of same elements appears at the start
    and end of the given array
*/
using System;

namespace Exercice_125
{
    class Program
    {
        public static bool IsSame(int[] numbers, int nElement)
        {
            int[] a = numbers[0..(nElement)],
                  b = numbers[^(nElement)..];
            
            for(int i = 0; i < a.Length; i++)
                if(a[i] != b[i]) return false;
            
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers and return
    true if the specified number of same elements appears at the start
    and end of the given array");

            Console.WriteLine(IsSame(new int[]{3,7,5,5,3,7},2));
            Console.WriteLine(IsSame(new int[]{3,7,5,5,3,7},3));
            Console.WriteLine(IsSame(new int[]{3,7,5,5,3,7,5},3));              
        }
    }
}
