/*
Write a C# Sharp program to create a new array of integers and length 1 or more.
The length of the new array will be double length of the given array and
    all the elements are 1 except the first element which is equal to the given array
*/
using System;
using System.Linq;

namespace Exercice_99
{
    class Program
    {
        public static int[] SetNewArray(int[] numbers)
        {
            int[] output =  new int[numbers.Length *2];
            output[0] = numbers[0];
            return output;         
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array of integers and length 1 or more.
The length of the new array will be double length of the given array and
    all the elements are 1 except the first element which is equal to the given array");
        Console.WriteLine(String.Join(",",SetNewArray(new int[]{10,20,-30,-40,3 })));
        }
    }
}
