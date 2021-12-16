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


            if ((lengthA+lengthB>lengthC)&(lengthB+lengthC>lengthA)&(lengthA+lengthC>lengthB))
            {
                Console.WriteLine($"Треугольник со сторонами ({lengthA.ToString()}, {lengthB.ToString()}, {lengthC.ToString()}) существует");
            }
            else
            {
                Console.WriteLine($"Треугольник со сторонами ({lengthA.ToString()}, {lengthB.ToString()}, {lengthC.ToString()}) не существует");
            }
        }
    }
}