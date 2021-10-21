using System;

namespace VVPLab4
{
    class Program
    {
        static Random rand = new Random(Guid.NewGuid().GetHashCode());

        static float inputA, inputB;
        static float sqrA, sqrB;

        static void Main(string[] args)
        {
            //inputA = rand.Next(-50, 50);
            //inputB = rand.Next(-50, 50);
            inputA = float.Parse(Console.ReadLine());
            inputB = float.Parse(Console.ReadLine());

            Console.WriteLine($"Original numbers: A={inputA}, B={inputB}");

            Console.WriteLine($"Summ = {MathF.Abs(inputA) + MathF.Abs(inputB)}");
            Console.WriteLine($"Diff = {MathF.Abs(inputA) - MathF.Abs(inputB)}");
            Console.WriteLine($"Mult = {MathF.Abs(inputA) * MathF.Abs(inputB)}");
            Console.WriteLine($"Div = {MathF.Abs(inputA) / MathF.Abs(inputB)}");
        }
    }
}
