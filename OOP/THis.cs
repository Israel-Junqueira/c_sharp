using System;

namespace This
{


    class Calculos//objeto calculo
    {
        public int v1; //propriedades
        public int v2; // propriedades

        public Calculos(int v1,int va2) // metodo construtor
        {
            this.v1 = v1; // o this serve para dizer que  essas variavel e referente as duas propriedades do objeto calculo, e NÂO O PARAMETRO 
            v2 = va2; // do metodo contrutor
                            //**deixei um exemplo q da pra usar sem o this tbm**// ai a maquina entender que o primeiro v1 pertence a propriedade , e o segundo  v1 pertence ao parametro
        }
                            // em resumo o this não e tão importante pq se trocar o nome da variavel ja da certo tbm, porem fica uma questão de 
                            //legibilidade facil para outros entenderem.

        public int Somar() //metodo
        {
            return v1 + v2;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Calculos c = new Calculos(10, 2);
            Console.WriteLine( c.Somar());
        }
    }
}
