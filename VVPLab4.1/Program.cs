using System;

namespace VVPLab4
{
    class Program
    {
        static float rectWidth;
        static float rectHeight;
        static float outputPerimeter;
        static float outputSquareSize;


        static void Main(string[] args)
        {
            Console.WriteLine("Input width x height");
            try
            {
                rectWidth = float.Parse(Console.ReadLine());
                rectHeight = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input");
                throw;
            }
            outputSquareSize = rectWidth * rectHeight;
            outputPerimeter = (rectWidth + rectHeight) * 2;

            Console.WriteLine($"Size = {outputSquareSize}, Perimeter = {outputPerimeter}");
        }
    }
}
