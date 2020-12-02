/*
Write a C# Sharp program to compute the sum of the three given integers.
However, if any of the values is in the range 10..20 inclusive 
    then that value counts as 0, except 13 and 17
*/
using System;

namespace Exercice_57
{
    class Program
    {
        public static int GetSum(int a, int b, int c)
        {
            int[] abc = {a,b,c};
            int sum = 0;

            foreach(int item in abc)
            {
                if(item < 10 || item > 20) sum += item;
                else if(item == 13 || item  == 17) sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Compute the sum of the three given integers.
However, if any of the values is in the range 10..20 inclusive 
    then that value counts as 0, except 13 and 17");

            Console.WriteLine(GetSum(4,5,7));
            Console.WriteLine(GetSum(7,4,12));
            Console.WriteLine(GetSum(10,13,12));
            Console.WriteLine(GetSum(17,12,18));
            Console.WriteLine(GetSum(17,13,17));
            Console.WriteLine(GetSum(10,11,12));
            Console.WriteLine(GetSum(15,14,15));
        }
    }
}
