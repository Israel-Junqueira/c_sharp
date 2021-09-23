using System;

namespace Comando_Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char escolha1;
            char escolha2,escolha3;

            inicio:
        tentarnovamente:
            Console.WriteLine("De igaraçu ate a barra");
            Console.WriteLine("Escolha os Transporte [a]Apé | [b]bicicleta | [m]moto");
            escolha1 = char.Parse(Console.ReadLine());

            if (escolha1 == 'a' | escolha1 == 'b' | escolha1 == 'm')
            {
                switch (escolha1)
                {
                    case 'A':
                    case 'a':
                        tempo = 30;
                        break;
                    case 'B':
                    case 'b':
                        tempo = 10;
                        break;
                    case 'M':
                    case 'm':
                        tempo = 5;
                        break;
                    default:
                        tempo = -1;
                        break;
                }
                Console.WriteLine("O tempo do transporte escolhido é: {0} minutos", tempo);
                Console.WriteLine("Gostaria de calcular outro tempo? | [s/n]");
                escolha3 = char.Parse(Console.ReadLine());
                if (escolha3 == 's' | escolha3 == 'S')
                {
                    Console.Clear();
                    goto inicio;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Obrigado volte sempre");
                }
            }
            else
            {

                Console.WriteLine("Verifique as opções e tente tovamente! ");
                Console.WriteLine("Deseja tentar novamente? [s/n]");
                escolha2 = char.Parse(Console.ReadLine());
                if (escolha2 == 's' | escolha2 == 'S')
                {
                    Console.Clear();
                    goto tentarnovamente;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Até a proxima!");
                }

            }


         

        }
    }
}