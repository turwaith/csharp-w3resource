/*
Write a C# program to find the size of a specified file in bytes.
Sample Output:
    Size of a file: 31
*/
using System;
using System.IO;

namespace Exercice_29
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = string.Empty;

            start:
                Console.Write("Enter the full path of the file to get its size (bytes): ");
                inputFilePath = Console.ReadLine();

                if(File.Exists(inputFilePath))
                {
                    FileInfo userFile = new FileInfo(inputFilePath);
                    Console.WriteLine($"{userFile.Name} : {userFile.Length} bytes");
                }
                else
                {
                    Console.WriteLine("Please enter a correct file path");
                    goto start;
                }
        }
    }
}
