using System;

namespace exec004
{

    class Exercicio
    {
            static void Main(string[] args)
        {
            // O Código começa aqui

            string nome;
            float nota1, nota2, nota3;
            
            Console.WriteLine("\nQual é o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("\nDigite a sua primeira nota:");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nDigite a sua segunda nota:");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nDigite a sua terceira nota:");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nSeu nome é {0}, sua primeira nota é {1}, sua segunda é {2} e a terceira é {3}.", nome, nota1, nota2, nota3);
            Console.WriteLine("\nSua média aritimética é {0:0.0}", (nota1 + nota2 + nota3) / 3);

        }
    }

}