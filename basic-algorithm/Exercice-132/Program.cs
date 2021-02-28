/*
Write a C# Sharp program to create new array from a given array of integers shifting all even numbers before all odd numbers
*/

using System;

namespace Exercice_132
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create new array from a given array of
            integers shifting all even numbers before all odd numbers");
            
            ShiftLeftEvens(new int[]{1,2,5,3,5,4,6,9,11});
            Console.WriteLine("-----");
            ShiftLeftEvens(new int[]{8,2,5,3,5,4,6,9,12});


        }

        static void ShiftLeftEvens(int[] numbers)
        {
            int size = numbers.Length;
            
            Console.WriteLine($"Old: [{String.Join(",",numbers)}]");

            for(int i = 0, pos = 0; i < size; i++, pos++)
            {
                if(numbers[i]%2 != 0)
                {
                    while(pos < size-1)
                    {
                        if(numbers[++pos] % 2 == 0)
                        {
                            int flag= numbers[i];
                            numbers[i] = numbers[pos];
                            numbers[pos] = flag;
                            pos = i+1;
                            break;
                        }
                    }
                }
            } 

            Console.WriteLine($"New: [{String.Join(",",numbers)}]");
        }
    }
}
