using System;

namespace exec010
{
    class Program
    {
        static void Main(string[] args)
        {

            string user, pw;

            Console.WriteLine("Digite seu usuario.");
            user = Console.ReadLine();

            Console.WriteLine("Digite sua senha.");
            pw = Console.ReadLine();

            if (user == "admin" && pw == "1234")
            {
                Console.WriteLine("\nBem-Vindo");
            }
            else
            {
                Console.WriteLine("\nAcesso Negado");
            }
        }
    }
}
