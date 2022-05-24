using System;

namespace exec016
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opcao, valorLimite;

            
            Console.Write("Digite 1 para exibir números ímpares ou 2 para exibir números pares: ");
            opcao = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor limite: ");
            valorLimite = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //Processamento com saída
            if (opcao == 1)
            {
                //Exibir só os ímpares
                for (int i = 1; i <= valorLimite; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                //Exibir só os pares
                for (int i = 2; i <= valorLimite; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
