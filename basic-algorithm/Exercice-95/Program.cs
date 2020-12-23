/*
Write a C# Sharp program to create a new array containing the middle
    elements from the two given arrays of integers, each length 5
*/
using System;

namespace Exercice_95
{
    class Program
    {
        public static int[] GetNewArray(int[] firstArray, int[] secondArray)
        {
            return new int[] {firstArray[2], secondArray[2]};
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Create a new array containing the middle
    elements from the two given arrays of integers, each length 5");

            Console.WriteLine(String.Join(",",GetNewArray(new int[]{10,20,-30,-40,30}, new int[]{10,20,30,40,30})));
        }
    }
}
