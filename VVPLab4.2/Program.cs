using System;

namespace VVPLab4
{
    class Program
    {
        static float diameter;
        static float output;        

        static void Main(string[] args)
        {
            Console.WriteLine("Input diameter");
            diameter = float.Parse(Console.ReadLine());
            output = diameter * MathF.PI;
            Console.WriteLine(output);
        }
    }
}
