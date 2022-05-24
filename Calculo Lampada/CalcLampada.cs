using System;

namespace exec011
{
    class Program
    {
        static void Main(string[] args)
        {
            float watts, watts2, area, largura, comprimento, total;

            Console.WriteLine("Qual a potência da sua lâmpada em watts?");
            watts2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual a largura do seu cômodo em metros?");
            largura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual a comprimento do seu cômodo em metros?");
            comprimento = Convert.ToSingle(Console.ReadLine());

            area = largura * comprimento;
            watts = area * 18;
            total = (watts2 / watts2);
            Console.WriteLine("Você vai precisar de {0} lâmpadas para não bater com o dedinho em algum lugar do cômodo.", total);

        }
    }
}
