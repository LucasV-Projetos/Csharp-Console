using System;

namespace exec021
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal[] nota;
            string[] nome;
            string c;
            int nome, a, b;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Defina a quantidade de notas desejado: ");
            nome = Convert.ToInt32(Console.ReadLine());
            nota = new decimal[nome];

            for (int i = 0; i < nome; i++)
            {
            Console.Write("Digite suas notas: ");
            nota[i] = Convert.ToInt32(Console.ReadLine());
            }

            a = nota.GetLength(nome);
            for (int i = 0; i < a; i++)
            {
                b = (int)(a + nota[i]);                   
            }
            b = nome / a;
            Console.WriteLine(b); 

        }
    }
}
