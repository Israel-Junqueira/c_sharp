using System;

namespace Classes_e_Obejtos
{
    //classes statics não permitem instanciar objetos,e nem construtores/destrutores

    static class Jogador
    {                                                                              // CLASSES E OBJETOS 2 (CLASSE COM STATIC" )
        static public int idade;
        static public bool ativo;
        static public string nome;

       static public void iniciar(string n, int idad, bool ati) 
        {
            idade = idad;
            ativo = ati;
            nome = n;
        }

        static public void info()
        {
            Console.WriteLine("nome Jogador:{0}", nome);
            Console.WriteLine("idade Jogador:{0}", idade);
            Console.WriteLine("Estado Jogador:{0}", ativo);
            Console.WriteLine("____________________________________");
        }
    }

    class aula28
    {
        static void Main() // public , private , protected, abstract , sealed , virtual ,static
        {
            string nome;
            int idade;
            bool ativo;

          /*  Console.WriteLine("Digite o nome do jogador 1:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            idade =int.Parse( Console.ReadLine());                  // para deixar autonomo fiz os console.witline
            Console.WriteLine("O jogador está ativo?:");               // porem tem q atribuir depois as variaveis nos parametros
            ativo = bool.Parse(Console.ReadLine());*/
            
                             //parametros.
            Jogador.iniciar("Rael",21,true);
            Jogador.info();


            //------------------------------------------------------------------------------------------


            inimigo i1 = new inimigo("tafarel"); //instanciando os objetos
            inimigo i2 = new inimigo("jadson");
            inimigo i3 = new inimigo("sopordeus");

            inimigo.alerta = true; // pra mudar pra true precisei colocar o bool alerta em static

            i1.info();
            i2.info();
            i3.info();

            
        }
    }

    class inimigo
    {

     static public  bool alerta;//coloque aq como statica para ela ter acesso na classe main
      public  string nome; // propriedades || ou variaveis

       public inimigo(string n) //construtor
        {
            alerta = false;
            nome = n;
        }

     public  void info()
        {
            Console.WriteLine(nome);
            Console.WriteLine(alerta);
            Console.WriteLine("_______________________________");
        }
    }


}
