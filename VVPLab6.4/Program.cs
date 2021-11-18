using System;

namespace VVPLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            Console.WriteLine("Enter X");
            x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"F(3x^6-6x^2-7) = {(3*MathF.Pow(x,6)-6*MathF.Pow(x,2)-7).ToString()}");
        }
    }
}