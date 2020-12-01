/*
Write a C# Sharp program to compute the sum of the three integers. 
If one of the values is 13 then do not count it and its right towards the sum
*/
using System;

namespace Exercice_56
{
    class Program
    {
        static public int GetSum(int a, int b, int c)
        {
            if(a == 13) return 0;
            if(b == 13) return a;
            if(c == 13) return a + b;
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Compute the sum of the three integers. 
If one of the values is 13 then do not count it and its right towards the sum");

            Console.WriteLine(GetSum(4,5,7));
            Console.WriteLine(GetSum(7,4,12));
            Console.WriteLine(GetSum(10,13,12));
            Console.WriteLine(GetSum(13,12,18));
            Console.WriteLine(GetSum(4,5,13));

        }
    }
}
