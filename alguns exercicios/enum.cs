using System;

namespace Enum
{
    class CursoEnum
    {
        enum diasdasemana { domingo, segunda, terça, quarta, quinta, sexta, sábado };  //fora do metodo
        static void Main(string[] args)
        {
            var ds = (diasdasemana)0;//chama o valor de enum pelo indice
            var dss = diasdasemana.quarta; // chamar pelo nome
            int dsss = (int)diasdasemana.quarta;//converte o nome para o indice


            Console.WriteLine($"{ds}  {dss}  {dsss}");
            

        }
    }
}