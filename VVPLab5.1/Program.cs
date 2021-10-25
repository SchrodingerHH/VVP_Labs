using System;

namespace VVPLab5
{
    class Program
    {
        private static float pointXFirst,pointYFirst;
        private static float pointXSecond,pointYSecond;
        private static float output;
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first point coords");
            pointXFirst = float.Parse(Console.ReadLine());
            pointYFirst = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second point coords");
            pointXSecond = float.Parse(Console.ReadLine());
            pointYSecond = float.Parse(Console.ReadLine());
            
            output = MathF.Sqrt(MathF.Pow((pointXSecond - pointXFirst), 2) + MathF.Pow(pointYSecond - pointYFirst, 2));
            Console.WriteLine(output);
        }
    }
}