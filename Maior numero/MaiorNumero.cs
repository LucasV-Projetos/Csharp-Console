using System;

namespace exec007
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1, n2;

            Console.WriteLine("Digite um número");
            n1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            n2 = Convert.ToDecimal(Console.ReadLine());

            if (n1 < n2)
            {
                Console.WriteLine("\nSeu número maior é " + n2);
            }
            else if (n1 == n2)
            {
                Console.WriteLine("\nSeus números são idênticos :o");
            }
            else
            {
                Console.WriteLine("\nSeu número maior é " + n1);
            }
        }
    }
}
