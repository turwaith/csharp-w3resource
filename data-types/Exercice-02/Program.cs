/*
Write a C# Sharp program that takes a number and a width also a number,
    as input and then displays a triangle of that width, using that number
*/
using System;

namespace Exercice_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Takes a number and a width also a number, as input
and then displays a triangle of that width, using that number");

            DisplayTriangle(GetWidth());
        }

        private struct Triangle
        {
            public Triangle(int nb, int w)
            {
                Number = nb;
                Width = w;
            }
            public int Number {get;set;}
            public int Width {get;set;}
        }
        
        static Triangle GetWidth()
        {
            int number, width;

            Console.Write("Enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a width : ");
            width = Convert.ToInt32(Console.ReadLine());

            return new Triangle(number, width);
        }

        static void DisplayTriangle(Triangle triangle)
        {
            for(int i = triangle.Width, min = 0; i > min; i--)
            {
                Console.WriteLine(new String(triangle.Number.ToString()[0], i));
            }
        }
    }
}
