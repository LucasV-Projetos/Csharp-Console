using System;

namespace exec025
{
    class Program
    {
        static void Main(string[] args)
        {
            float raio;

            Console.Write("Digite o raio da circunferência: ");
            raio = float.Parse(Console.ReadLine());

            //area = (float)(Math.PI * Math.Pow(raio, 2));

            Console.WriteLine("Sua area é {0:0.00}m", Area(raio));
        }
            
        static float Area(float raio)
        {
        float r = raio;
        for (int i = 0; i < r; i++)
        {
            r = (float)(3.14159265359 * raio * raio); 
        }
        return r;
        }
    }
}
