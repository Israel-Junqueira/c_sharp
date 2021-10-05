using System;

namespace valor_e_referencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num1 = 10;

           dobrar(ref num);
            Console.WriteLine(num);//referencia a variavel para o console ler e entender q faz referencia ao calculo

             triplica(ref num1);// sem o ref ele não mostraria o numero triplicado
            Console.WriteLine(num1);
        }

        static void dobrar(ref int valor)
        {
            valor *= 2;
            
        }

        static void triplica(ref int valor)
        {
            valor *= 3;

        }



    }
}
