using System;

namespace VVPLab5
{
    class Program
    {
        private static float pointXA,pointYA;
        private static float pointXB,pointYB;
        private static float output;
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A point coords");
            pointXA = float.Parse(Console.ReadLine());
            pointYA = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter B point coords");
            pointXB = float.Parse(Console.ReadLine());
            pointYB = float.Parse(Console.ReadLine());
            
            float width = MathF.Abs(pointYA-pointYB);
            float height = MathF.Abs(pointXA-pointXB);
            
            Console.WriteLine($"P = {width*2+height*2}, S = {width*height}"); 
            
        }
    }
}