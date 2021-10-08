using System;

namespace algoritmo_par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Title="Elebore o algoritmo";
            Console.WriteLine("informe um numero");
            n = int.Parse(Console.ReadLine());

             
            if (n %2 == 0)
            {
                Console.WriteLine("O numero e par");
            }
            else
            {
                Console.WriteLine("é impar");
            }
        }
    }
}
