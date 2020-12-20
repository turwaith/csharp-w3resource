/*
Write a C# Sharp program to compute the sum of the elements
    of an given array of integers
*/
using System;
using System.Linq;

namespace Exercice_91
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Compute the sum of the elements
    of an given array of integers");
            
            Console.WriteLine(new int[]{10,20,30,40,50}.Sum());
            Console.WriteLine(new int[]{10,20,-30,-40,50}.Sum());
        }
    }
}
