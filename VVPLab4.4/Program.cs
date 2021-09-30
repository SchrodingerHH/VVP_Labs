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
            inputA = rand.Next(1, 50);
            inputB = rand.Next(1, 50);
            sqrA = MathF.Pow(inputA, 2);
            sqrB = MathF.Pow(inputB, 2);

            Console.WriteLine($"Original numbers: A={inputA}, B={inputB}");

            Console.WriteLine($"Summ = {sqrA + sqrB}");
            Console.WriteLine($"Diff = {sqrA - sqrB}");
            Console.WriteLine($"Mult = {sqrA * sqrB}");
            Console.WriteLine($"Div = {sqrA / sqrB}");
        }
    }
}
