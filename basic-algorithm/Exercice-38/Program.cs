/*
Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers.
Also count the situation where the second 5 is actually a 6
*/
using System;

namespace Exercice_38
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNumbers;
            int count = 0;

            Console.WriteLine("Count the number of two 5's are next to each other in an array of integers." +
                              "\nAlso count the situation where the second 5 is actually a 6");
        
            Console.Write("Enter your numbers (coma separeted): ");
            userNumbers = Console.ReadLine().Split(",");

            for(int i = 0; i <= (userNumbers.Length - 2); i++)            
                if(userNumbers[i] == "5" && (userNumbers[i+1] == "5" || userNumbers[i+1] == "6")) count++;  

            Console.WriteLine($"Output: {count}");
        }
    }
}
