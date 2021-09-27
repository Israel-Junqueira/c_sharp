using System;

namespace Loop_For_estrutura_de_iteração
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alfabeto = new string[5]{"A","B","C","D","E"};


            for (int letras=0;letras<alfabeto.Length;letras++)
            {
                Console.WriteLine(alfabeto[letras]);

            }

            int[] num = new int[5] {1,2,3,4,5 }; 

            for(int n = 0; n <num.Length; n++) 
            {
             
                Console.WriteLine(num[n]);
            
            
            }

            int[] num1 = new int[5] { 1, 2, 3, 4, 5 };

            for (int n = 0; n <num1.Length; n++)
            {
                num[n] = n;
                Console.WriteLine(num[n]);


            }




        }
    }
}
