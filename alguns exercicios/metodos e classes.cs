using System;

namespace Métodos
{
    class Program
    {
        static void Main()
        {
            hello();

            for (int i=0; i<10;i++) 
            {
                int recebe1, recebe2,r;

                recebe1=int.Parse(Console.ReadLine());

             
                recebe2=int.Parse(Console.ReadLine());

               r=soma(recebe1,recebe2);

                Console.WriteLine("o retor e:{0}",r);
            }

          
            
        }
        //objetos ou void que é sem retorno
      static int  soma(int n1,int n2)// para retornar use o int e o return
        {                            //da pra chamar os metodo e deixar sem argumentos soma(..argumentos..)
            int res = n1 + n2;
            return res;

        }

        static void hello()
        {
            Console.WriteLine("Fazendo somas, digite dois numeros");

        }
    }
}
