/*
Write a C# Sharp program to check a given array (length will be atleast 2) of
    integers and return true if there are two values 15, 15 next to each other
*/
using System;

namespace Exercice_134
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array (length will be atleast 2) of
    integers and return true if there are two values 15, 15 next to each other");

            Console.WriteLine(CheckIfTwins(new int[]{ 5, 5, 1, 15, 15 }));
            Console.WriteLine(CheckIfTwins(new int[]{ 15, 2, 3, 4, 15 }));
            Console.WriteLine(CheckIfTwins(new int[]{ 3, 3, 15, 15, 5, 5}));
            Console.WriteLine(CheckIfTwins(new int[]{ 1, 5, 15, 7, 8, 15}));            
            Console.WriteLine(CheckIfTwins(new int[]{ 15, 5, 15, 15, 8, 15}));            
            Console.WriteLine(CheckIfTwins(new int[]{ 1, 5, 15, 15}));            
        }

        static bool CheckIfTwins(int[] numbers, int pos = 0, int twins = 15)
        {
            int index = Array.IndexOf(numbers, twins, pos);         

            if(index == numbers.Length-1)   // break the recursive
                return false;
            else if(numbers[index+1] == twins)
                return true;
            
            return CheckIfTwins(numbers, index+1);
        }
    }
}
