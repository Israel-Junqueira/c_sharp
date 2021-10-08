using System;

namespace Classes_e_Obejtos
{
    //classes statics não permitem instanciar objetos,e nem construtores/destrutores

      class Jogador  // a classe pode ser public,abstract , sealed , static
    {
        public int energia = 100;                   // propriedades |ou| variaveis 
        public bool vivo = true;                    // propriedades  |ou| variaveis 
        public string nome="Jogador" ;

        public Jogador(string n)                    //método construtor
        {
            energia = 100;
            vivo = true;
            nome = n; 
        }

        public Jogador(string n,int ener) 
        {
            energia =ener;
            vivo = true;
            nome = n;
        }

        public Jogador(string n, int ener,bool vi) //criei tbm varias opções de construtor para a mesma classe
        {
            energia = ener;
            vivo = vi;
            nome = n;
        }

        public void info()                          //AQUI FOI A AULA DE SOBRECARGA DE CONSTRUTORES
        {
            Console.WriteLine("nome Jogador:{0}", nome);
            Console.WriteLine("energia Jogador:{0}", energia);
            Console.WriteLine("Estado Jogador:{0}", vivo);
            Console.WriteLine("____________________________________");
        }

        ~Jogador()  // método destrutor a diferença e o ~ 
        {
            Console.WriteLine("Jogador{0} foi deletado",nome);
        }



    }

    class aula28
    {
        static void Main() // public , private , protected, abstract , sealed , virtual ,static
        {
            string nome;
            Console.WriteLine("Digite o nome do jogador 1:");
            nome = Console.ReadLine();

            //****objeto****\\
            //classe | nome = new| Classe() 
            Jogador j1 = new Jogador(nome); // instaciei um novo objeto da classe jogador
            Jogador j2 = new Jogador("Théo",100); //new reserva um espaço no endereço da memoria para esse objeto
            Jogador j3 = new Jogador("godofredo",40,true);
            Jogador j4 = new Jogador("zogofredo",0,false);

            j1.info();//_______
            j2.info();//        ___
            j3.info();//        ___SOBRECARGA DE CONSTRUTORES
            j4.info();//_______

            /*//aqui usei os consoles.Writeline pois não tinha chamado como metodo info
            j1.energia = 50; // para alterar 
            Console.WriteLine("As caracteristicas do jogador 1 é: energia: [{0}] nome: [{1}] esta ativo: [{2}]", j1.energia, j1.nome, j1.vivo);
            Console.WriteLine("As caracteristicas do jogador 2 é: energia: [{0}] nome: [{1}] esta ativo: [{2}]", j2.energia,j2.nome, j2.vivo);
            Console.WriteLine("As caracteristicas do jogador 2 é: energia: [{0}] nome: [{1}] esta ativo: [{2}]", j3.energia, j3.nome, j3.vivo);
            Console.WriteLine("As caracteristicas do jogador 2 é: energia: [{0}] nome: [{1}] esta ativo: [{2}]", j4.energia, j4.nome, j4.vivo);*/


        }
    }






    //------------- --ESBOÇO DA CLASSE MOSTRADA NA AULA: ---------------------------------------//

    //      [ModificadorClasse] class NOME_DA_CLASSE
    //      {
    //      Variáveis / Propriedades
    //      [EspecificadorAcesso] tipo NOME_PROPRIEDADE;
    //      
    //      Metodos
    //      [EspecificadorAcesso] retorno NOME_METODO([arg1,...])
    //      {
    //      corpo do método
    //      }
    // }

    //-------O QUE SÃO E APLICAÇÕES:-----------------------------------------------//

    //      [ModificadorClasse]: Define a visibilidade da classe.
    //      public: pública, sem restrição de visualização.
    //      abstract: Classe-Base para outrsas classes, não podem ser instanciados a objetos desta classe
    //      sealed: Classe não pode ser herdada
    //      static: Classe não permite a instanciação de objetos e seus membros devem ser "static"
    //
    //      [EspecificadorAcesso]: Onde um membro da classe pode ser acessado
    //      public: pública, sem restrição de acesso.
    //      private: Só podem ser acessados pela própria classe.
    //      protected: Podem ser acessados na própria classe e nas classes derivadas
    //      abstract: Os métodos não tem implementação somente os cabeçalhos
    //      sealed: O método não pode ser redefinido.
    //      virtual: O método pode ser redefinido em uma classe derivada.
    //      static: o método pode ser chamado mesmo sem a instanciação de um objeto.
}
