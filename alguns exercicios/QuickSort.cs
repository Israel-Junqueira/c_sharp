using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,n2;
           

            Console.WriteLine("Forneça o tamanho da lista:");
             n = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("_________________________________________________");

            int[] numeros = new int[n];

            for (int i = 0;i<n;i++ )  //introdução de dados no array
            {
                Console.WriteLine("Informe o numero: [{0}]",i);
                n2= int.Parse ( Console.ReadLine());
                
                numeros[i] = n2;
                
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("ultimo numeros usado:{0}",numeros[i]);
            }
           
            Console.WriteLine("_________________________________________________");




            sortArray(numeros);//chama o metodo sortarray e manda o array numeros para o sortarray

            foreach (var numero in numeros ) // mostra a ordem dos numeros
            {
                Console.WriteLine("a nova ordem dos numeros é: {0}",numero);
            
            }

            Console.WriteLine("o menor numero é {0} e o maior é {1}",numeros[0],numeros[n-1]); // mostra o maior e o menor


          

        }

        private static void sortArray(int[] numeros) // criei uma função chamada SortArray para  podemos passar este array numeros
        {
            Quicksort(numeros,0,numeros.Length -1); 
                                                    // Passei a matriz "numeros",
                                                    // o começo da matriz "0" , e o fim do array "-1" lembrando -1 para não pegar o tamanho inteiro e sim so o da indice
        }

        private static void Quicksort(int[] numeros,int esquerda,int direita)// matriz , e duas variaveis que serão usadas
        {
            int e = esquerda;
            int d = direita;

            var pivot = numeros[(esquerda + direita) / 2];

           while(e <= d) 
            {
                while (numeros[e] < pivot)
                    e++;

                while (numeros[d] > pivot)
                    d--;
                 
                if (e <= d)
                {
                    var tmp = numeros[e];
                    numeros[e] = numeros[d];
                    numeros[d] = tmp;
                    e++;
                    d--;
                }
            }
            if (esquerda < d)
                Quicksort(numeros, esquerda, d);

            if (e < direita)
                Quicksort(numeros, e, esquerda);

        }
    }
}
