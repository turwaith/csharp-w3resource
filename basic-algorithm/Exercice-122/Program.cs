/*
Write a C# Sharp program to check a given array of integers and return true if
    the given array contains either 2 even or 2 odd values all next to each other
*/
using System;

namespace Exercice_122
{
    class Program
    {
        public static bool IsEvenOrOdd(int[] numbers)
        {
            for(int i = 0; i < numbers.Length -1; i++)            
                if((numbers[i] % 2 == 0  && numbers[i+1] % 2 == 0) ||
                   (numbers[i] % 2 != 0  && numbers[i+1] % 2 != 0))
                    return true;            
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers and return true if
    the given array contains either 2 even or 2 odd values all next to each other");

            Console.WriteLine(IsEvenOrOdd(new int[]{3,5,1,3,7}));
            Console.WriteLine(IsEvenOrOdd(new int[]{1,2,3,4}));
            Console.WriteLine(IsEvenOrOdd(new int[]{3,3,5,5,5,5}));
            Console.WriteLine(IsEvenOrOdd(new int[]{2,4,5,6}));
        }
    }
}
