using System;

namespace Matrizes_vetores_bidimensionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[5,3]; // o primeiros numero são as linhas e o segundo colunas.
            int[,] num2 = new  int[2,2] { {10,30 },{20,60 } };


     /*  1    10,30
              20,60    */

            /*
                 10,20, 30
                 40,50, 60 
                 70,80, 90
                 15,30, 45
                 12,25,78
             */

            num[0,0] =10 ;
            num[0,1] =20 ;
            num[0,2] =30 ;
            
            num[1,0] =40 ;
            num[1,1] =50 ;
            num[1,2] =60 ;

            num[2, 0] = 70;
            num[2, 1] = 80;
            num[2, 2] = 90;

            num[3, 0] = 15;
            num[3, 1] = 30;
            num[3, 2] = 45;

            num[4, 0] = 101;
            num[4, 1] = 120;
            num[4, 2] = 78;



            Console.WriteLine(num[2,1]);
        }
    }
}
