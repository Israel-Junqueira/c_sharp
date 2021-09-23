using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3,media;
            num1 = 2;
            num2 = 5;
            num3 = 3;

            media = (num1 + num2 + num3) / 3;

            if (media < 5)
            {
                Console.WriteLine("reprovador");
                Console.WriteLine("quer tentar recuperar sua nota? sim ou não");
                string conf = Console.ReadLine();
                if (conf=="sim")
                {
                    Console.WriteLine("segunda as 10, não falte");
                }
                else
                {
                    Console.WriteLine("Te vejo ano que vem ");
                }


            }
            else
            {
                Console.WriteLine("aprovado");
            }



        }
    }
}