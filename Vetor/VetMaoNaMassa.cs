using System;

namespace exec018
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] nomes, sobrenomes;
            int tamVetores;

            Console.Write("Informe quantos nomes e sobrenomes irá preencher: ");
            tamVetores = int.Parse(Console.ReadLine());

            //Instanciar os vetores (indicar o tamanho deles)
            nomes = new string[tamVetores];
            sobrenomes = new string[tamVetores];

            //Entrada do vetor nomes
            for (int pos = 0; pos < nomes.Length; pos++)
            {
                Console.Write("Informe um nome: ");
                nomes[pos] = Console.ReadLine();
            }

            //Entrada do vetor sobrenomes
            for (int pos = 0; pos < sobrenomes.Length; pos++)
            {
                Console.Write("Informe um sobrenome: ");
                sobrenomes[pos] = Console.ReadLine();
            }

            Console.WriteLine("\nNomes com seus sobrenomes:");

            //Saída: vetor nomes com vetor sobrenomes
            for (int pos = 0; pos < tamVetores; pos++)
            {
                Console.WriteLine("{0} {1}", nomes[pos], sobrenomes[pos]);
            }
        }
    }
}
