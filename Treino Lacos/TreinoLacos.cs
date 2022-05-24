using System;

namespace exec015
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal i2 = 1; 
            decimal i3 = 1;

            while (i2 <= 100)
            {
                Console.WriteLine(i2);
                i2++;
            }
            for (int i = 1; i <= 100; i++)
            {
               Console.WriteLine(i); 
            }
            do
            {
                Console.WriteLine(i3);
                i3++;
            } while (i3 <= 100);
 



            
        }
    }
}
