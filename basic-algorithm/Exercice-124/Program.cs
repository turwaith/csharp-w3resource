/*
Write a C# Sharp program to check a given array of integers and return
    true if every 5 that appears in the given array is next to another 5
*/
using System;
using System.Linq;

namespace Exercice_124
{
    class Program
    {
        public static bool IsNext(int[] numbers, int nb = 5)
        {
            bool serie = false;

            for (int i = 0, size = numbers.Length; i < size; i++)
            {
                if(numbers[i] == nb && i > 0 && numbers[i-1] == nb)                                    
                    serie = true;   // start of a serie                
                else if(serie && i < size - 1 && numbers[i+1] == nb)    
                    serie = false;  // it's a serie but now broken if next i == nb
            }
            return serie;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers and return
    true if every 5 that appears in the given array is next to another 5");

            Console.WriteLine(IsNext(new int[] {3,5,5,3,7}));
            Console.WriteLine(IsNext(new int[] {3,5,5,4,1,5,7}));
            Console.WriteLine(IsNext(new int[] {3,5,5,5,5,5}));
            Console.WriteLine(IsNext(new int[] {2,4,5,5,6,7,5}));
        }
    }
}
