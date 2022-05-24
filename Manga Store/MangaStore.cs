using System;

namespace exec006
{
    class Program
    {
        private const double V = 3.99;

        static void Main(string[] args)
        {
            float manga1 = 3.99F;
            float manga2 = 2.99F;
            float compra;

            Console.WriteLine("Quantas mangas você comprou?");
            compra = Convert.ToSingle(Console.ReadLine());


            if (compra >= 12)
            {    
                Console.Write("O preço das suas mangas é R$" + manga2 * compra);
            }
            else
            {
                Console.WriteLine("O preço das suas mangas é R$" + manga1 * compra);
            }
        
        }   
    }
}
