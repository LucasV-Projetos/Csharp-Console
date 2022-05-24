using System;

namespace exec007
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;

            /* Console.WriteLine("Digite um número");
            n1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            n2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            n3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Seu número maior é " + (Math.Max(n1 ,Math.Max(n2, n3))));
            Console.WriteLine("Seu número menor é " + (Math.Min(n1 ,Math.Min(n2, n3)))); */

            Console.WriteLine("Digite um número");
            n1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite outro número");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite mais um número");
            n3 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O seu número maior é " + n1);
            }
            else if(n2 > n1 && n2 > n3)
            {
                Console.WriteLine("O seu número maior é " + n2);
            }
            else if(n3 > n1 && n3 > n2)
            {
                Console.WriteLine("O seu número maior é " + n3);
            }



            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("O seu número menor é " + n1);
            }
            else if(n2 < n1 && n2 < n3)
            {
                Console.WriteLine("O seu número menor é " + n2);
            }
            else if(n3 < n1 && n3 < n2)
            {
                Console.WriteLine("O seu número menor é " + n3);
            }
        }
    }
}
