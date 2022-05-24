using System;

namespace exec014
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nota1, nota2;
            double media;
            string nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua primeira nota: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite sua segunda nota: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());

            media = (double)(nota1 + nota2 / 2);

            if (media <= 3)
            {
                Console.WriteLine("{0} reprovado(a)", nome);
            }

            else if (media > 3 && media < 5.9)
            {
                Console.WriteLine("{0} de exame!" ,nome);
            }
            
            else if (media >= 6)
            {
                Console.WriteLine("{0} aprovado(a)!" ,nome);
            }

        }
    }
}
