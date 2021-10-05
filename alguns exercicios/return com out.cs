using System;

namespace Argumento_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo, divisor,cal,resto2,soma2;
            dividendo = 11;
            divisor = 5;
            soma2 = 1;
            cal = divide(dividendo, divisor,out resto2,out soma2);


            Console.WriteLine("{0}/{1}, e igual ha {2}, de resto {3}, e a conta doida de soma {4} ",dividendo,divisor,cal,resto2,soma2);
        }

        static int divide(int dividendo, int divisor,out int resto,out int soma)
        {
            
           int cal = dividendo / divisor;
            resto = dividendo % divisor;
           soma = resto + dividendo;
            return cal;
            
            
        }
    }
}
