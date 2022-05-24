using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exec026
{
    class Program
    {
        static void Main(string[] args)
        {

        List<Carro> carro = new List<Carro>();
        List<Carro> carros = new List<Carro>();

        do
        {
        

        Console.Write("----==== PROGRAMA DE CADASTRO DE VEÍCULOS ====----\n");
        Console.Write("1 - Cadastrar veículo\n");
        Console.Write("2 - Listar veículos\n");
        Console.Write("0 - Sair\n\n");

        Console.Write("Informe a opção desejada: ");
        decimal escolha = Convert.ToDecimal(Console.ReadLine());
        

            if (escolha == 0)
            {
                Console.Clear();
                Task.Delay(1000);
                return;
            }

            if (escolha == 1)
            {
                Carro veiculo = new Carro();

                Console.Clear();
                Console.WriteLine("Informe os dados necessarios.\n");

                Console.Write("Qual é a marca do veículo: ");
                veiculo.Marca = Console.ReadLine();

                Console.Write("Qual o modelo: ");
                veiculo.Modelo = Console.ReadLine();

                Console.Write("Ano: ");
                veiculo.Ano = Convert.ToDecimal(Console.ReadLine());
                
                Console.Write("Quantos Reais: ");
                veiculo.Preco = Convert.ToDouble(Console.ReadLine());

                carro.Add(veiculo);
                Console.Clear();
            }
            
            if (escolha == 2)
            { 
                Console.Clear();
                Console.WriteLine("Veiculos Cadastrados: ");

               foreach (Carro veiculos in carro)
                {
                    Console.WriteLine("Marca: {0}, Modelo: {1}, Ano: {2}, Preço: R${3}", veiculos.Marca, veiculos.Modelo, veiculos.Ano, veiculos.Preco);
                }
                Console.Write("\n\n");
            }

        } while (true);          
    }
}



    class Carro
    {
        private string _marca;
        private string _modelo;
        private decimal _ano;
        private double _preco;



        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public decimal Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
    }
}