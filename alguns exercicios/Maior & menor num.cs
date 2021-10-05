using System;

namespace Maior_e_menor_numero_Variavel
{
    class Program
    {
        static void Main(string[] args)
        {                                               //sem ordenamento
            int i, qn ,maior,menor,primeironum;

            Console.WriteLine("informe a quantidade de numeros que serão usados:");
            qn =int.Parse( Console.ReadLine());
            Console.WriteLine("informe o primeiro numero");
            primeironum = int.Parse(Console.ReadLine());


            maior = primeironum;
            menor = primeironum;
            i = 1;

            for (i = 2; i < qn; i++)
            {
                Console.WriteLine("informe o numero {0}",i);
                primeironum =int.Parse (Console.ReadLine());
                if (primeironum < menor)
                {
                    menor = primeironum;
                }
                if (primeironum > maior)
                {
                    maior = primeironum;
                }

            }

            Console.WriteLine("O maior numero e {0} , e o menor numero é {1}", maior, menor);
            Console.ReadKey();


        }
    }
}
