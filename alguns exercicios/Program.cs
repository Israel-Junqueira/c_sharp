using System;

namespace ATIVIDADE_BIDO__3_SETEMBRO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             decimal p, qp, vp, sub,mult;
             Console.WriteLine("QUANTAS PRESTAÇÕES SÂO AO TOTAL?");
             p=Convert.ToDecimal(Console.ReadLine());
             Console.WriteLine("QUANTAS O SENHOR PAGOU?");
             qp = Convert.ToDecimal(Console.ReadLine());
             Console.WriteLine("QUAL O VALOR DA PRESTAÇÃO");
             vp = Convert.ToDecimal(Console.ReadLine());

             sub = p - qp;
             mult = sub * vp;

             Console.WriteLine(" O total pago pelo consorcio foi de R$ {0:N} e o saldo devedor é de R$ {1:N}",mult,sub);
            */

            /*

            string nome;
            int no1, no2, no3,soma;

            Console.Title =( "REPROVAÇÂO PARA MEDIA ABAIXO DE 5");  
            Console.WriteLine("Qual nome do aluno?");
            nome = Console.ReadLine();
            Console.WriteLine("Primeira nota do "+nome);
            no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segunda nota do "+nome);
            no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Terceira nota do "+nome);
            no3 = Convert.ToInt32(Console.ReadLine());

            soma = (no1 + no2 + no3) / 3;

            if (soma >= 5)
            {
                Console.WriteLine("A media é "+soma);
                Console.WriteLine(nome+" Foi Aprovado, Parabens!!");
            }
            else
            {
                Console.WriteLine("A media é " + soma);
                Console.WriteLine(nome+" Foi Reprovado, Estude mais para melhores resultados!"); 
            }
              */
            /*
            double custf,cimp,revecust,consf;

            Console.WriteLine("Diga qual e o custo de fabricação");
            custf = double.Parse(Console.ReadLine());
            
            cimp = 0.45 * custf;
            revecust = 0.25*custf;
            Console.WriteLine("Custo de revenda é: "+revecust);
            Console.WriteLine("Custo de imposto é: "+cimp);

            consf = custf + cimp + revecust;
            Console.WriteLine("Custo do consumidor final é:"+consf);
            */

            /* double salariofixo, totalvendas, comi,soma;
             string nome;
             Console.WriteLine("Qual nome do vendedor?");
             nome=Console.ReadLine();

             Console.WriteLine("Diga qual é o salario fixo do "+nome);
             salariofixo = double.Parse(Console.ReadLine());

             Console.WriteLine("total de vendas do " + nome);
             totalvendas = double.Parse(Console.ReadLine());


             comi = 0.15 * totalvendas;
             soma = comi + salariofixo;

             Console.WriteLine("A comissão do: "+nome+" é " + comi);
             Console.WriteLine("O salario fixo do: " + nome + " é " + salariofixo+ " somando a comisão ficará "+soma);
            */

            /*
            decimal cota, saldo,real;
            
            
            Console.WriteLine("Qual a cotação atual do Dolar?");
            cota = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu saldo atual:(US$)");
            saldo = decimal.Parse(Console.ReadLine());


            real = cota * saldo;

          
            Console.WriteLine("Seu saldo em R$ é: " + real);
            */

               /*
            double Vp, j, t, multa, Tmora, mora;

            Console.WriteLine("Informe o valor da prestação:");
            Vp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a taxa de juros");
            j = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o tempo");
            t = Convert.ToDouble(Console.ReadLine());

            multa = Vp + (j / 100) * Vp;

            mora = Vp * 1 / 100;
            Tmora = t * mora / 30;
            double somoj = Tmora + multa;
            Console.WriteLine("sua multa é de: " + somoj.ToString("F"));
            */
        }

       
    }
}
