using System;

namespace equação_2__grau
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta,xbascara1, xbascara2;
            a = 2;
            b = 3;
            c =-5;       
            Console.WriteLine($"Resolvendo Equação (aX² + bx + c=0)");
            
            delta = Math.Pow(b,2)+(-4*a*c) ;
            xbascara1 = (-b + Math.Sqrt(delta)) / (2 * a);
            xbascara2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("O valor de X1 é:{0:N}, e o Valor de X2 é: {1:N}",xbascara1,xbascara2);
        }
    }
}