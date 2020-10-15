/*
Write a C# program to sort the integers in ascending order without moving the number -5.
*/
using System;

namespace Exercice_61
{
    class Program
    {
        static void SortArrayExcept(int[] nums, int intException)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != -5)
                {
                    for(int j = i+1; j < nums.Length; j++)
                    {
                        if(nums[j] == -5) break;
                        else if(nums[j] < nums[i])
                        {
                            int temp = nums[j];
                            nums[j] = nums[i];
                            nums[i] = temp;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] numsOne = {0,-5,4,-3,10,-5,2,1,-5},
                  numsTwo = {-5, 236, 120, 70, -5, -5, 698, 280 };


            Console.WriteLine($"Array one without sorting: [{string.Join(",",numsOne)}]");
            SortArrayExcept(numsOne, -5);            
            Console.WriteLine($"Array one with sorting   : [{string.Join(",",numsOne)}]");
            
            Console.WriteLine($"Array two without sorting: [{string.Join(",",numsTwo)}]");
            SortArrayExcept(numsTwo, -5);
            Console.WriteLine($"Array two with sorting   : [{string.Join(",",numsTwo)}]");

        }
    }
}
