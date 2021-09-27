using System;

namespace loop_While_estruturas_de_interação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] {1,2,3,4,5};

            int i =num1.Length-1; // no while precisamos criar uma variavel fora, diferente do for que e possivel criar dentro do parametro
                                    // usa-se o -1 pq o length pega o numero do indice e da errado,
                                    // pq na verdade ela tem sempre uma posição a menos por conta que começa do zero
            
            /*
             exemplo1 
            while (i<10) // aqui ele testa se essa expressão e verdadeira e se for ele executa oque está dentro do comando.
            {         
                Console.WriteLine("Teste de numero 1");
                i++;
            };
            
             */
            //exemplo2
            while (i >= 0) 
            {
                
                Console.WriteLine(num1[i]);
                i--;
               
            };

        }
    }
}
