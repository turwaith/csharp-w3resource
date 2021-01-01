/*
Write a C# Sharp program to compute the sum of the numbers in a given array
    except those numbers starting with 5 followed by atleast one 6.
Return 0 if the given array has no integer.
*/
using System;

namespace Exercice_112
{
    class Program
    {
        public static int GetSum(int[] numbers)
        {
            if(numbers.Length == 0) return 0;
            else
            {
                int sum = 0;
                for(int i = 0; i < numbers.Length; i++)
                {
                    if(numbers[i] == 5 && i < numbers.Length - 1 && numbers[i+1] == 6)                    
                        i++;
                    else
                        sum += numbers[i];                    
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Compute the sum of the numbers in a given array
    except those numbers starting with 5 followed by atleast one 6.
Return 0 if the given array has no integer.");

            Console.WriteLine("Sum of the numbers of the said array except those numbers" +
                              "starting with 5 followed by atleast one 6:");
            Console.WriteLine(GetSum(new int[]{5,6,1,5,6,9,10,17,5,6}));
            Console.WriteLine(GetSum(new int[]{5,6,1,5,6,9,10,17}));
            Console.WriteLine(GetSum(new int[]{1,5,6,9,10,17,5,6}));
            Console.WriteLine(GetSum(new int[]{1,5,9,10,17,5,6}));
            Console.WriteLine(GetSum(new int[]{1,5,9,10,17,5}));
            Console.WriteLine(GetSum(new int[]{}));
        }
    }
}
