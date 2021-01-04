/*
Write a C# Sharp program to check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both
*/
using System;
using System.Linq;

namespace Exercice_119
{
    class Program
    {
        public static bool IsNext(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if((numbers[i] == 3 && numbers[i+1] == 3) ||
                   (numbers[i] == 5) && numbers[i+1] == 5)
                   return true;                
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both");

            Console.WriteLine(IsNext(new int[]{5,5,5,5,5}));
            Console.WriteLine(IsNext(new int[]{1,2,3,4}));
            Console.WriteLine(IsNext(new int[]{3,3,5,5,5,5}));
            Console.WriteLine(IsNext(new int[]{1,5,5,7,8,10}));            
        }
    }
}
