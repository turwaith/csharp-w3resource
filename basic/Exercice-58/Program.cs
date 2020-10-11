/*
Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range.
    Sample Example [1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8 are not present in the list.
    So output will be 4.
*/
using System;
using System.Collections;

namespace Exercice_58
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] integersList = {1, 3, 4, 7, 9};
            int count = 0;

            Console.WriteLine("Accept a list of integers and checks how many integers are needed to complete the range");

            for(int i = 0; i < integersList.Length -1; i++)
            {                
                count += integersList[i+1] - integersList[i] - 1;
            }

            Console.WriteLine($"Integers missing: {count}");
        }
    }
}
