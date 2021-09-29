using System;

namespace Metodos_para_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[6] {55,44,33,22,11,77 };
            int[] v2 = new int[6] {11,22,33,44,55,77 };
            int[] v3 = new int[5];
            int[,] matriz = new int[2,6]{{11,22,00,44,55,66 },{66,77,88,99,00,66 }};

            // Preenchimento com numeros aleatorios 
            /*
                        Random random = new Random();
                        for (int i =0;i<v1.Length;i++)
                        {
                            v1[i] = random.Next(50);
                            Console.WriteLine(v1[i]);
                        }

                       //---------------------------------------------------------------
                       //Procurar valores nas indices dos vetores.
                       // public static int BinarySearch(array,valor);

                        int procurado = 11;
                        int pos = Array.BinarySearch(v2,procurado);
                        Console.WriteLine("O valor de: {0} está na posição: {1}",procurado,pos);

                        //----------------------------------------------------------------

                        // public static void Copy(Array_origem,Array_destino,qtde_elementos);
                        Array.Copy(v2,v1,v2.Length);
                        foreach (int i in v2)
                        {
                            Console.WriteLine(i);
                        }
                        //------------------------------------------------------------------

                        //copyTo(Array_destino,a_partir_desta_posição);


                        v1.CopyTo(v3,0);
                        foreach (int i in v3)
                        {
                            Console.WriteLine(i);
                        }

                        //--------------------------------------------------------------------

                        //mostra o tamanho da indice

                        long Elementosdovetor = matriz.GetLongLength(0); // para matrizes use 0 para mostrar as linhas e 1 para mostrar as colunas
                        Console.WriteLine(Elementosdovetor);

                        //---------------------------------------------------------------------

                        //int GetLowerBoud (dimensão)

                        int menorindiceVetor = v1.GetLowerBound(0);
                        int menorindiceMatrz = matriz.GetLowerBound(1);
                        Console.WriteLine(menorindiceMatrz);
                        Console.WriteLine(menorindiceVetor);
                        //---------------------------------------------------------------------

                        //int GetUpperBaund(dimensão) ele conta sempre um a menos por conta que começa com o 0 1 2 3 4 
                        int menorindiceVetor = v1.GetUpperBound(0);
                        int menorindiceMatrz = matriz.GetUpperBound(0);
                        Console.WriteLine(menorindiceMatrz);
                        Console.WriteLine(menorindiceVetor);
                        //--------------------------------------------------------------------

                        // public object GetValue(long indice);
                        int valor0 = Convert.ToInt32(v1.GetValue(3));
                        int valor1 = Convert.ToInt32(matriz.GetValue(1,4));
                        Console.WriteLine(valor1);
                        Console.WriteLine(valor0);
            
            //IndexOf(array,valor);                 //lembrando q ele conta -1 por causa do 0
            int indice1 = Array.IndexOf(v1,33);
            Console.WriteLine(indice1);
            
            //----------------------------------------------------------------------------------

            //void Reverse(array);
             Array.Reverse(v1);
            foreach(int n in v1)
            {
                Console.WriteLine(n);
            }
          //---------------------------------------------------------------------------------------   
                        //object pq pode ser string,char,int
            // void SetValue(object valor, posição);
            v1.SetValue(99, 0);
            foreach (int n in v1)
            {
                Console.WriteLine(n);
            }
*/          //-------------------------------------------------------------------------------------

            Array.Sort(v1);// coloca na ordem crescente 
            Array.Reverse(v1);// inverte as posiçoes 
            foreach (int n in v1)
            {
                Console.WriteLine(n);
            }






        }
    }
}
