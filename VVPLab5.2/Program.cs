using System;

namespace VVPLab5
{
    class Program
    {
        private static float pointXA,pointYA;
        private static float pointXB,pointYB;
        private static float pointXC,pointYC;
        private static float output;
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A point coords");
            pointXA = float.Parse(Console.ReadLine());
            pointYA = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter B point coords");
            pointXB = float.Parse(Console.ReadLine());
            pointYB = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter C point coords");
            pointXC = float.Parse(Console.ReadLine());
            pointYC = float.Parse(Console.ReadLine());
            
            float ACline = MathF.Sqrt(MathF.Pow((pointXC - pointXA), 2) + MathF.Pow(pointYC - pointYA, 2));
            float BCline = MathF.Sqrt(MathF.Pow((pointXC - pointXB), 2) + MathF.Pow(pointYC - pointYB, 2));
            Console.WriteLine($"AC = {ACline}, AB = {BCline}, summ = {ACline+BCline}");
        }
    }
}