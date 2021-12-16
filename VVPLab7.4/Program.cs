using System;

namespace VVPLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            float carSpeed1, carSpeed2, distance , time, output;
            Console.WriteLine("Введите скорость первой машины");
            carSpeed1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите скорость Второй машины");
            carSpeed2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите начальное расстояние между машинами");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите прошедшее время с начала пути");
            time = Convert.ToSingle(Console.ReadLine());
            output = (carSpeed1 + carSpeed2) * time + distance;
            Console.WriteLine($"Расстояние между машинами спустя {time.ToString()} часов = {output.ToString()}");
        }
    }
}