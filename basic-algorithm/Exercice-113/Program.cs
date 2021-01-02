/*
Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere
*/
using System;

namespace Exercice_113
{
    class Program
    {
        public static bool DoubleFiveInside(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
                if(i < numbers.Length - 1 && numbers[i] == 5 && numbers[i+1] == 5)
                    return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check if a given array of integers contains 5 next to a 5 somewhere");

            Console.WriteLine(DoubleFiveInside(new int[]{1,5,6,9,10,17}));
            Console.WriteLine(DoubleFiveInside(new int[]{1,5,5,9,10,17}));
            Console.WriteLine(DoubleFiveInside(new int[]{1,5,5,9,10,17,5,5}));
        }
    }
}
