using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };//dessa forma ñão ter limitação
            int[] numeros2 = new int[5]; // dessa forma eu declaro o quanto sera a capacidade de armazenamento
            int[] numeros3 = new int[5] { 1, 2, 3, 4, 5 }; //dessa forma ja declaro os valores.
            string[] equipamentos = new string[2] { "mause","teclado" };
            numeros2[0] = 10;
            numeros2[1] = 11;
            numeros2[2] = 12;
            numeros2[3] = 13;
            numeros2[4] = 14;

            Console.WriteLine(numeros[]);
        }
    }
}
