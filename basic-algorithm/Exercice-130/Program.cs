/*
Write a C# Sharp program to create a new array from a given array of integers shifting all zeros to left direction
*/
using System;

namespace Exercice_130
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array from a given array of integers
            shifting all zeros to left direction");
            
            int[] numsOne = {1,2,0,3,5,7,0,9,11},
                  numsTwo = {0,8,0,0,1,2,0,0,5};;

            ZeroToLeft(numsOne);
            Console.WriteLine("----");
            ZeroToLeft(numsTwo);
        }
        static void ZeroToLeft(int[] numbers)
        {
            int count = 0,
                size = numbers.Length;
            int[] output = new int[numbers.Length];

            Console.WriteLine($"Old array: [{String.Join(",",numbers)}]");

            for(int i = 0; i < size; i++)
            {
                if(numbers[i] == 0)
                    count++;
            }

            for(int i = 0, pos = 0; i < size; i++)
            {
                if(numbers[i] != 0)
                {
                    output[count+pos] = numbers[i];
                    pos++;
                }
            }

            Console.WriteLine($"Old array: [{String.Join(",",output)}]");
        }
    }
}
