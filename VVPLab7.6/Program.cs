using System;

namespace VVPLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, a1, a2, b1, b2, c1, c2;
            Console.WriteLine("Дана система линейных уравнений вида {A1*X+B1*Y=C1 A2*X+B2*Y=C2}");
            Console.WriteLine("Введите числа A1");
            a1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите числа B1");
            b1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите числа C1");
            c1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите числа A2");
            a2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите числа B2");
            b2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите числа C2");
            c2 = Convert.ToSingle(Console.ReadLine());

            x = Convert.ToSingle((c2 - (b2 * c1)) / ((b1 * a2) - a1));
            y = Convert.ToSingle((c1 - (a1 * x)) / b1);
            Console.WriteLine($"x = {x.ToString()}, y = {y.ToString()}");
        }
    }
}