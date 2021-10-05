using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int saldoatual, deposito,resposta,saque;
            char novaop;

            saldoatual = 1200;

            Console.WriteLine("Saldo atual {0}",saldoatual);
            voltar:
            Console.WriteLine("Ir para:[a]SAQUE [b] Deposito [c]outros");
            resposta = char.Parse(Console.ReadLine()); 

            if (resposta == 'a' | resposta == 'A')
            {
                Console.WriteLine("Quanto deseja sacar?, saldo atual de {0}",saldoatual);
                saque = int.Parse(Console.ReadLine());

                saldoatual -= saque;

                Console.WriteLine("Seu salto atual é de {0}",saldoatual);

                Console.WriteLine("gostaria de fazer uma nova operação? [s/n]");
                novaop =char.Parse( Console.ReadLine());

                if (novaop == 's')
                {
                    goto voltar;
                }
                else
                {
                    Console.WriteLine("A caixa agrace!");
                }

            }else if (resposta == 'b' | resposta == 'B')
            {
                Console.WriteLine("Quanto deseja depositar?, saldo atual de {0}", saldoatual);
                deposito = int.Parse(Console.ReadLine());

                saldoatual += deposito;

                Console.WriteLine("Seu salto atual é de {0}", saldoatual);

                Console.WriteLine("gostaria de fazer uma nova operação? [s/n]");
                novaop = char.Parse(Console.ReadLine());

                if (novaop == 's')
                {
                    goto voltar;
                }
                else
                {
                    Console.WriteLine("A caixa agrace!");
                }

            }
            else if (resposta == 'c' | resposta == 'C')
            {
             

                Console.WriteLine("ISSO NÃO VEM AO CASO AGORA VOLTA PRA Lá ");

                Console.WriteLine("gostaria de fazer uma nova operação? [s/n]");
                novaop = char.Parse(Console.ReadLine());

                if (novaop == 's')
                {
                    goto voltar;
                }
                else
                {
                    Console.WriteLine("A caixa agrace!");
                }



            }

            
            
           
        }
    }
}
