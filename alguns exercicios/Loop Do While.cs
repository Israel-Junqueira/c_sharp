using System;

namespace Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            do
            {                                                       // a diferença e que um não pensa pra fazer 
                Console.WriteLine("Hello World!");
            } while (num < 5);


            while (num < 5)
            {                                                       // e o outro pensa 
                Console.WriteLine("Hello World2!");
            }


            //excercicio do while

            string senha = "123";
            string senhauser;
            int tentativas = 3;
        
            do
            {
                if (tentativas <= 0)
                {
                    Console.WriteLine("Senha incorreta, Usuario bloqueado");
                    break;

                }
               
                    Console.Clear();
                    Console.WriteLine("[{0}] Tentativas", tentativas);
                    Console.WriteLine("Digite a senha:");
                    senhauser = Console.ReadLine();
                
                    tentativas--;
                
            } while (senhauser != senha);


            Console.Clear();
            Console.WriteLine("Senha correta!");
        }
    }
}
