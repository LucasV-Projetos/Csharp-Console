using System;

namespace exec012
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal poligono;
            double medida, altura, bas;

            Console.WriteLine("Digite o número de lados do polígono");
            poligono = Convert.ToDecimal(Console.ReadLine());


            if (poligono == 3)
            {
                Console.WriteLine("Digite a medida em centímetros");
                medida = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("É um triangulo. Aqui esta o perímetro: {0}cm²" ,medida * 3);
            }
            else if (poligono == 4)
            {
                Console.WriteLine("Digite a altura em centímetros");
                altura = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Digite a base em centímetros");
                bas = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("É um quadrado, sua área é de {0}cm²" ,altura * bas);
            }
            else if (poligono == 5)
            {
                Console.WriteLine("É um polígonos ");
            }
            else if (poligono >= 6)
            {
                Console.WriteLine("Não implementado.");
            }

        }
    }
}
