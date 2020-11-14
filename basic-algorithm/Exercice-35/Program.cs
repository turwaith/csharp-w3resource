/*
Write a C# Sharp program to compare two given strings
    and return the number of the positions where they contain the same length 2 substring
*/
using System;
using System.Linq;

namespace Exercice_35
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   userLargerString = String.Empty,
                   userSmallerString = String.Empty;
            int count = 0;

            Console.WriteLine("Compare two given strings and return the number of the positions\n "+
                              "where they contain the same length 2 substring");

            Console.Write("Enter the first string: ");
            userInput = Console.ReadLine();
            userSmallerString = userInput;

            Console.Write("Enter the second string: ");
            userInput = Console.ReadLine();
            if(userInput.Length < userSmallerString.Length)
            {
                userLargerString = userSmallerString;
                userSmallerString = userInput;
            }
            else userLargerString = userInput;
            
            //Console.WriteLine($"Smaller {userSmallerString} \nLarger {userLargerString}");

            for(int i = 0; i < userSmallerString.Length-1; i+=2)
            {                
                if(userLargerString.Contains(userSmallerString[i..(i+2)])) count++;
            }            

            Console.WriteLine($"Output: {count}");
        }
    }
}
/*
for(int j = 0; j <   userLargerString.Length; j+=2)
                {
                    if(userSmallerString[i..(i+2)] == userLargerString[i..(j+2)]) count++;
                }
                */
