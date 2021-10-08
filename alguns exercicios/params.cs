using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n1,n2;
            Console.WriteLine("informe quantos numeros vc quer somar");
            n1 = int.Parse(Console.ReadLine());

            int[] num1 = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                 
                Console.WriteLine("informe o numero {0}",i);
                n2 = int.Parse(Console.ReadLine());
                num1[i] = n2;
            }
            // aqui vc pode substituir pelo num1, como uma forma de teste sem o params, que dará certo tbm
            soma(1,2,3,4,5,6);// aqui a diferença e o params,na segunda classe,
                              // se eu usar numeros invez do meu array num1 que declarei mais acima
            //ele dará o erro que não declarei os argumentos o suficiente

            // eu acrecentei so a parte autonoma para o usuario digitar os valores e não eu
            // porém em um caso em que vc de os valores e seja sem um array voce precisará usar o params
           
        }
                                    //deixei comentado o params para mostrar o erro
        private static void soma(/*params*/ int[] n)
        {
            int res=0;
            if (n.Length < 1)
            {
                Console.WriteLine("informe pelo menos dois numeros positivos");
            }
            else if (n.Length < 2)
            {
                Console.WriteLine("informe pelo menos mais um numero");
            }
            else
            {

                for (int i = 0; i < n.Length; i++)
                {
                    res += n[i];
                }
                Console.WriteLine("soma dos {0} numeros é {1}",n.Length, res);
            } 
        }
    }
}
