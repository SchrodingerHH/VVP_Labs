using System;

namespace VVPLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilogramsX, priceX, kilogramsY, pricePerKilo;

            Console.WriteLine("Введите количество кг первой покупки");
            kilogramsX = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите общую цену");
            priceX = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите количество кг второй закупки");
            kilogramsY = Convert.ToSingle(Console.ReadLine());
            
            pricePerKilo = priceX / kilogramsX;
            Console.WriteLine($"Цена за 1 килограмм = {pricePerKilo.ToString()}, цена за Y {kilogramsY.ToString()}кг = {(pricePerKilo*kilogramsY).ToString()}");
        }
    }
}