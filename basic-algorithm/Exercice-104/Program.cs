/*
Write a C# Sharp program to create a new array from two give array of integers, each length 3
*/
using System;

namespace Exercice_104
{
    class Program
    {
        public static int[] SetNewArray(int[] firstArray, int[] secondArray)
        {
            int[] output = new int[firstArray.Length + secondArray.Length];
            firstArray.CopyTo(output,0);
            secondArray.CopyTo(output,firstArray.Length);
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new array from two give array of integers, each length 3");

            Console.WriteLine($"{{{String.Join(",", SetNewArray(new int[]{10,20,30}, new int[]{30,40,50}))}}}");
        }
    }
}
