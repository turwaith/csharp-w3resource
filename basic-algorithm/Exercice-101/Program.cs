/*
Write a C# Sharp program to check a given array of integers,
    length 3 and create a new array. 
If there is a 5 in the given array immediately followed by a 7 then set 7 to 1
*/
using System;

namespace Exercice_101
{
    class Program
    {
        public static void ChangeArray(int[] numbers)
        {
            int indexOfFive = 0;           

            indexOfFive = Array.IndexOf(numbers, 5);

            Console.WriteLine($"Original array: {{{String.Join(",",numbers)}}}");

            if(indexOfFive >= 0 && numbers[indexOfFive+1] == 7)            
                numbers[indexOfFive+1] = 1;
            
            Console.WriteLine($"New array     : {{{String.Join(",",numbers)}}}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(@"Check a given array of integers, length 3 and create a new array. 
If there is a 5 in the given array immediately followed by a 7 then set 7 to 1");

            ChangeArray(new int[]{1,5,7});
            ChangeArray(new int[]{5,7,7});
            ChangeArray(new int[]{5,8,7});
        }
    }
}
