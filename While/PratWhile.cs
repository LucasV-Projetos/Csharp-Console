using System;

namespace exec013
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1;
            decimal a1 = 0;


            while (a1 < 5)
            {
            Console.WriteLine("Digite o nome");
            n1 = Console.ReadLine();
            Console.WriteLine(n1);
            a1 += 1;
            }
        }
    }
}
