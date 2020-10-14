/*
Write a C# program to calculate the sum of all the intgers of a rectangular 
    matrix except those integers which are located below an intger of value 0.
    Sample Example:
    matrix = [[0, 2, 3, 2],
    [0, 6, 0, 1],
    [4, 0, 3, 0]]
    Eligible integers which will be participated to calculate the sum -
    matrix = [[X, 2, 3, 2],
    [X, 6, X, 1],
    [X, X, X, X]]
    Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14
*/
using System;

namespace Exercice_60
{
    class Program
    {
        static int GetSum(int[,] matrix)
        {
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(1); i++)
            {
                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    if(matrix[j,i] <= 0) break;
                    else sum += matrix[j,i];
                }
            }
            return sum;
        }
        static void DisplayOriginalMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[");                
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                    if(j != matrix.GetLength(1) - 1) Console.Write(",");
                }
                Console.Write("]");
                Console.Write(i != matrix.GetLength(0) - 1 ? "\n" : "");
            }
        }
        static void DisplayCorrectedMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[");                
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == 0 && i < matrix.GetLength(0) - 1) matrix[i+1,j] = 0;
                    Console.Write(matrix[i,j] == 0 ? "x" : Convert.ToString(matrix[i,j]));
                    if(j != matrix.GetLength(1) - 1) Console.Write(",");
                }
                Console.Write("]");
                Console.Write(i != matrix.GetLength(0) - 1 ? "\n" : "");
            }
        }
        static void Main(string[] args)
        {
            // array of array [,] or [][]
            int[,] matrixOne = {{0,2,3,2},
                                {0,6,0,1},
                                {4,0,3,0}};
            int[,] matrixTwo = {{1,2,1,0},
                                {0,5,0,0},
                                {1,1,3,10}};
            int[,] matrixThree = {{1,1},
                                  {2,2},
                                  {3,3},
                                  {4,4}};           

            Console.WriteLine("Matrix one:");
            DisplayOriginalMatrix(matrixOne);
            Console.WriteLine("\n\tEligible integers which will be participated to calculate the sum");
            DisplayCorrectedMatrix(matrixOne);
            Console.WriteLine($"\n\tTherefore sum will be: {GetSum(matrixOne)}");

            Console.WriteLine("Matrix two:");
            DisplayOriginalMatrix(matrixTwo);
            Console.WriteLine("\n\tEligible integers which will be participated to calculate the sum");
            DisplayCorrectedMatrix(matrixTwo);
            Console.WriteLine($"\n\tTherefore sum will be: {GetSum(matrixTwo)}");

            Console.WriteLine("Matrix three:");
            DisplayOriginalMatrix(matrixThree);
            Console.WriteLine("\n\tEligible integers which will be participated to calculate the sum");
            DisplayCorrectedMatrix(matrixThree);
            Console.WriteLine($"\n\tTherefore sum will be: {GetSum(matrixThree)}");
        }
    }
}
