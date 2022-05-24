using System;

namespace exec008
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num, num2;

            Console.WriteLine("Digite um número.");
            num = Convert.ToDecimal(Console.ReadLine());

            num2 = num % 2;

            if (num2 == 0)
            {
                Console.WriteLine("O seu número é par.");
            }
            else
            {
                Console.WriteLine("O seu número é impar.");
            }
        }
    }
}
