/*
 Write a C# Sharp program to check a given array of integers and return true
    if the value 5 appears 5 times and there are no 5 next to each other
 */
using System;
using System.Linq;

namespace Exercice_123
{
    class Program
    {
        public static bool IsFiveTimes(int[] numbers)
        {
            if(numbers.Count(item => item == 5) < 5)
                return false;
            for(int i = 0; i < numbers.Length-1; i++)
                if(numbers[i] == 5 && numbers[i+1] == 5)
                    return false;                    
            return true;            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers and return true
    if the value 5 appears 5 times and there are no 5 next to each other");

            Console.WriteLine(IsFiveTimes(new int[]{3,5,1,5,3,5,7,5,1,5}));
            Console.WriteLine(IsFiveTimes(new int[]{3,5,5,5,5,5,5}));
            Console.WriteLine(IsFiveTimes(new int[]{3,5,2,5,4,5,7,5,8,5}));
            Console.WriteLine(IsFiveTimes(new int[]{2,4,5,5,5,5}));
        }
    }
}
