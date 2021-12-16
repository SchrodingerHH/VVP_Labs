using System;

namespace VVPLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            float lengthA, lengthB, lengthC;
            Console.WriteLine("Введите длину стороны A");
            lengthA = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите длину стороны B");
            lengthB = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите длину стороны C");
            lengthC = Convert.ToSingle(Console.ReadLine());


            if (TriCheck(lengthA,lengthB,lengthC) || TriCheck(lengthB,lengthA,lengthC) || TriCheck(lengthC,lengthA,lengthB))
            {
                Console.WriteLine($"Треугольник со сторонами ({lengthA.ToString()}, {lengthB.ToString()}, {lengthC.ToString()}) является прямоугольным");
            }
            else
            {
                Console.WriteLine($"Треугольник со сторонами ({lengthA.ToString()}, {lengthB.ToString()}, {lengthC.ToString()}) не является прямоугольным");
            }

            bool TriCheck(float lengthA, float lengthB, float lengthC)
            {
                //return lengthA*lengthA == lengthB*lengthB + lengthC*lengthC;
                return MathF.Pow(lengthA, 2) == MathF.Pow(lengthB, 2) + MathF.Pow(lengthC, 2);
            }
        }
    }
}