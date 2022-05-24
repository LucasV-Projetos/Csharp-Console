using System;

namespace exec017
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = ' ';
            Double celsius, fahrenheit;

            do
            {
                
                Console.Write(Escolha());

                if (escolha == 0)
                    return;

                else if (escolha == 1)
                {
                    Console.Write("Digite a temperatura em Celsius para converter em Fahrenheit: ");
                    celsius = Convert.ToInt16(Console.ReadLine());
                    fahrenheit = celsius * 1.8 + 32;
                    Console.WriteLine("\nSua temperatura de {0}°C equivale a {1:0,0}°F\n\n", celsius, fahrenheit);
                }
                else if (escolha == 2)
                {
                    Console.Write("Digite a temperatura em Fahrenheit para converter em Celcius: ");
                    fahrenheit = Convert.ToInt16(Console.ReadLine());
                    celsius = (fahrenheit - 32) / 1.8;
                    Console.WriteLine("\nSua temperatura de {0}°F equivale a {1:0,0}°C\n\n", fahrenheit, celsius);
                }
            } while (true);
        }

        private static int Escolha()
        {
            throw new NotImplementedException();
        }

        static Int16 Escolha(Int16 escolha)
        {
            Console.WriteLine("Digite o número desejado para fazer as operações.\n");
            Console.WriteLine("1 - Para converter de Celsius para Fahrenheit");
            Console.WriteLine("2 - Para converter de Fahrenheit para Calsius");
            Console.WriteLine("0 - Para sair do programa.\n");
            Console.Write("Digite a opção desejada: ");
            escolha = Convert.ToInt16(Console.ReadLine());
            return escolha;
        }
        
    }  
}