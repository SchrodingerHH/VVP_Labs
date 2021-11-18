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
            Console.WriteLine($"F(4(x-3)^6-7(x-3)^3+2) = {(4*MathF.Pow(x-3,6)-7*MathF.Pow(x-3,3)+2).ToString()}");
        }
    }
}