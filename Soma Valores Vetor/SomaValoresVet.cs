using System;

namespace exec019
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1, vet2, vet3;
            int n;

            Console.Write("Defina a quantidade de valores para soma: ");
            n = Convert.ToInt32(Console.ReadLine());

            vet1 = new int[n];
            vet2 = new int[n];
            vet3 = new int[n];

            for (int i = 0; i < n; i++)
            {
            Console.Write("Digite os valores do primeiro array para soma: ");
            vet1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
            Console.Write("Digite os valores do segundo array para soma: ");
            vet2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int pos = 0; pos < n; pos++)
            {
                Console.WriteLine("{0} + {1} = {2}", vet1[pos], vet2[pos], vet1[pos] + vet2[pos]);
            }

        }
    }
}
