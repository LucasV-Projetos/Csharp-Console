using System;

namespace exec022
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat1;
            int l, c;

            Console.Write("Defina a quantidade de linhas desejadas: ");
            l = Convert.ToInt32(Console.ReadLine());
            mat1 = new double[l,0];

            Console.Write("Defina a quantidade de colunas desejadas: ");
            c = Convert.ToInt32(Console.ReadLine());
            mat1 = new double[l,c];

            for (int i = 0; i < l; i++)
            {
            Console.Write("Digite os números da linha: ");
            mat1[i,c] = Convert.ToDouble(Console.ReadLine());
            }

        }
    }
}
