﻿/*
Write a C# Sharp program to check a given array of integers and return true if
    the given array contains two 5's next to each other,
    or two  5 separated by one element
*/
using System;

namespace Exercice_120
{
    class Program
    {
        public static bool IsNext(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if((numbers[i] == 5) && (numbers[i+1] == 5 || numbers[i+2] == 5))
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers and return true if
    the given array contains two 5's next to each other,
    or two  5 separated by one element");

            Console.WriteLine(IsNext(new int[]{5,5,1,5,5}));
            Console.WriteLine(IsNext(new int[]{1,2,3,4}));
            Console.WriteLine(IsNext(new int[]{3,3,5,5,5,5}));
            Console.WriteLine(IsNext(new int[]{1,5,5,7,8,10}));
        }
    }
}
