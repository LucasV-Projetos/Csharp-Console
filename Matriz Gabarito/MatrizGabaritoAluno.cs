using System;

namespace exec024
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] alunosResp;
            string[] gabarito = new string[10];
            int alunos;
            char notasAleatorias;
            string notas;

            Console.Write("Digite a quantidade de alunos: ");
            alunos = int.Parse(Console.ReadLine());
            alunosResp = new string[alunos,12];


            for (int i = 0; i < alunos; i++)
            {
                Console.Write("Digite o(s) nome(s): ");
                alunosResp[i,0] = Console.ReadLine();
            }
            

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite 10 notas do gabarito (notas de A a D): ");
                gabarito[i] = Console.ReadLine();
            }


            for (int i = 0; i < alunos; i++)
            {
                for (int ii = 1; ii < 11; ii++)
                {
                Random rnd = new Random();
                notasAleatorias = Convert.ToChar(rnd.Next(97, 101));
                notas = Convert.ToString(notasAleatorias);
                alunosResp[i,ii] = notas;
                }
            }


            for (int i = 0; i < alunos; i++)
            {
            int acertos = 1;
            int index = 0;
                for (int ii = 1; ii < 11; ii++)
                {
                    if (alunosResp[i,ii] == gabarito[index])
                    {
                    alunosResp[i, 11] = Convert.ToString(acertos++);
                    index++;
                    }
                }
            
            }


            Console.WriteLine("A nota final dos alunos são...");
            for (int i = 0; i < alunos;i++)
            {
                Console.WriteLine("aluno {0} com {1} acertos", alunosResp[i,0], alunosResp[i,11]);
            }


        }
    }
}
