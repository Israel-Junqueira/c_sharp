using System;

namespace FOR_EACH
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3] { 1, 2, 3 };

           /* for(int i=0;i<num.Length;i++)
            { Console.WriteLine(num[i]);
                
            }*/
            foreach(int n in num) // bom para fazer a leitura do valor de uma coleção (vetor)
            {
                Console.WriteLine(n);
            }

        }
    }
}
