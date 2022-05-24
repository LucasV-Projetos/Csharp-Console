using System;

namespace exec005
{
    class Program
    {
        static void Main(string[] args)
        {
            float area, raio;

            Console.WriteLine("Digite o raio da circunferência:");
            raio = Convert.ToSingle(Console.ReadLine());

            area = (float)(Math.PI * Math.Pow(raio, 2));

            Console.WriteLine("Sua area é {0:0.00}m", area);

        }
    }
}
