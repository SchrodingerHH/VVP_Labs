using System;

namespace VVPLab5
{
    class Program
    {
        private static float APoint;
        private static float BPoint;
        private static float CPoint;
        
        static void Main(string[] args)
        {
            APoint = float.Parse(Console.ReadLine());
            BPoint = float.Parse(Console.ReadLine());

            CPoint = float.Parse(Console.ReadLine());
            if ((APoint>CPoint && CPoint>BPoint) || (BPoint>CPoint && CPoint>APoint))
            {
                Console.WriteLine(MathF.Abs(APoint-CPoint)*MathF.Abs(BPoint-CPoint));
            }
            else
            {
                Console.WriteLine("Invalid numbers");
            }

            
        }
    }
}