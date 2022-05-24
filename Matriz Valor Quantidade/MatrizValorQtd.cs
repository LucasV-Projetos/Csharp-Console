using System;

namespace exec023
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matriz;
            int l, c, v;

            Console.Write("Digite a quantidade de linhas: ");
            l = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a quantidade de colunas: ");
            c = int.Parse(Console.ReadLine());
            
            matriz = new int[l,c];

            for (int i = 0; i < l; i++)
            {
                for (int ii = 0; ii < c; ii++)
                {
                Console.Write("Insira os valores: ");
                v = int.Parse(Console.ReadLine());
                matriz[i,ii] = v;
                }
            }
            Console.Write("Valores da matriz\n");
            for (int linha = 0; linha < l; linha++)
            {
                for (int coluna = 0; coluna < c; coluna++)
                {
                    ;
                    Console.Write(matriz[linha, coluna] + " ");
                }
                Console.WriteLine();
            }




            for (int linha = 0; linha < l; linha++)
            {
                for (int coluna = 0; coluna < c; coluna++)
                {
                    if (matriz[linha,coluna] > 10)
                    {
                    Console.WriteLine("A matriz possui {} valores acima de 10.");
                    }
                    else
                    {
                    Console.WriteLine("Não tem valor maior que 10.");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
