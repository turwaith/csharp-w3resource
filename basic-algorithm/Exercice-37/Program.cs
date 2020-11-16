/*
Write a C# Sharp program to create a new string of the characters at indexes 0,1,4,5,8,9 ... from a given string
*/
using System;

namespace Exercice_37
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput =  String.Empty,
                   inputModified = String.Empty;
            int[] indexes = new int[] {0,1,4,5,8,9};

            Console.WriteLine("Create a new string of the characters at indexes 0,1,4,5,8,9 ... from a given string");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            for(int i = 0; i < userInput.Length; i++)            
                if(Array.Exists(indexes, elt => elt == i)) inputModified += userInput[i];            

            Console.WriteLine($"Original: {userInput}\nModified: {inputModified}");
        }
    }
}