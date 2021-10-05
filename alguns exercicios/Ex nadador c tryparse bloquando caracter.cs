using System;

namespace exercicio_do_nadador
{
    class Program
    {
        static void Main(string[] args)
        {
            string recebestring,notnul;
            int idade;
            bool result;


        inicio:

            Console.WriteLine("Qual a idade do nadador?");
            notnul = Console.ReadLine();

            result = int.TryParse(notnul, out idade);

            if (result == true)
            {
                if (idade <= 7 && idade >= 5)
                {
                    Console.WriteLine("Infantil A");

                }

                else if (idade >= 8 && idade <= 10)
                {
                    Console.WriteLine("Infantil B");
                }

                else if (idade >= 11 && idade <= 13)
                {
                    Console.WriteLine("juvenil A");
                }

                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("juvenil A B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Categoria adulta");
                }

                Console.WriteLine("Deseja inserir uma nova idade?[s/n]");
                recebestring = Console.ReadLine().ToUpper();
                if (recebestring == "S")
                {
                    goto inicio;
                }

            } else
            {
                Console.Clear();
                Console.WriteLine("****** Digite apenas numeros *******");
                Console.WriteLine("****** Digite apenas numeros *******");
                Console.WriteLine("****** Digite apenas numeros *******");
                Console.WriteLine("****** Digite apenas numeros *******");
                Console.WriteLine("****** Digite apenas numeros *******");
                Console.WriteLine("____________________________________");
                Console.WriteLine("Deseja inserir uma nova idade?[s/n]");
                recebestring = Console.ReadLine().ToUpper();
                if (recebestring == "S")
                {
                    goto inicio;
                }
            } 



           

          
            
            
        }

    }
}
