using System;

namespace exec020
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal[] vet1;
            int n;

            Console.Write("Defina a quantidade de números desejado: ");
            n = Convert.ToInt32(Console.ReadLine());
            vet1 = new decimal[n];

            for (int i = 0; i < n; i++)
            {
            Console.Write("Digite os números para ordenar: ");
            vet1[i] = Convert.ToDecimal(Console.ReadLine());
            }
    
            Array.Sort(vet1);
            Console.WriteLine("Números ordenados: ");
            for (int pos = 0; pos < n; pos++)
            {
                Console.WriteLine(vet1[pos]);                
            }
        }
    }
}
